using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace N게시_관리자
{
    public partial class Form_admin : Form
    {
        public Form_admin()
        {
            InitializeComponent();
        }
        IFirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "QdFVDqfo0mn05RVXQbLTG104z0CgGTJm5M0GQK2S",
            BasePath = "https://n-memberservice-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void Form_admin_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fbc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FirebaseClient 초기화에 실패했습니다: " + ex.Message);
                client = null;
            }
        }
        private async void join_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any field is empty
                if (string.IsNullOrWhiteSpace(join_name.Text) || string.IsNullOrWhiteSpace(join_id.Text) || string.IsNullOrWhiteSpace(join_pw.Text))
                {
                    MessageBox.Show("모든 항목을 입력해주세요.");
                    join_name.Text = "";
                    join_id.Text = "";
                    join_pw.Text = "";
                    return;
                }

                // 중복 사용자 검사
                var query = await client.GetAsync("users/" + join_id.Text);
                if (query == null)
                {
                    throw new Exception("회원 목록을 가져오는데 실패했습니다.");
                }

                var user = query.ResultAs<Data>();
                if (user != null)
                {
                    MessageBox.Show("이미 존재하는 사용자입니다.");
                }
                else
                {
                    // 사용자 생성
                    DateTime now = DateTime.Now;
                    Data data = new Data()
                    {
                        name = join_name.Text,
                        id = join_id.Text,
                        pw = join_pw.Text,
                        expireDate = now.AddMonths(1)
                    };

                    // 회원가입
                    var response = await client.SetAsync("users/" + join_id.Text, data);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("회원가입이 완료되었습니다.");

                        // TextBox 초기화
                        join_name.Text = "";
                        join_id.Text = "";
                        join_pw.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void search_Click(object sender, EventArgs e)
        {
            try
            {
                // Firebase에서 모든 회원 정보 가져오기
                var query = await client.GetAsync("users");
                var users = query.ResultAs<Dictionary<string, Data>>();

                // DataTable 객체 생성
                DataTable dt = new DataTable();
                dt.Columns.Add("member_name");
                dt.Columns.Add("member_id");
                dt.Columns.Add("member_pw");
                dt.Columns.Add("ExpireDate");

                // 회원 정보를 DataTable에 추가
                foreach (var user in users)
                {
                    dt.Rows.Add(user.Value.name, user.Value.id, user.Value.pw, user.Value.expireDate.ToString("yyyy-MM-dd tt mm분 ss초"));
                }

                // memberList에 데이터 표시
                memberList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void extend_button_Click(object sender, EventArgs e)
        {
            try
            {
                // 사용자 정보 가져오기
                var query = await client.GetAsync("users/" + extend_id.Text);
                if (query == null)
                {
                    throw new Exception("사용자 정보를 가져오는데 실패했습니다.");
                }

                var user = query.ResultAs<Data>();
                if (user == null)
                {
                    throw new Exception("해당하는 사용자가 존재하지 않습니다.");
                }

                // expireDate 늘리기
                user.expireDate = user.expireDate.AddMonths(1);

                // Firebase에 업데이트
                var response = await client.UpdateAsync("users/" + extend_id.Text, user);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("연장이 완료되었습니다.");

                    // TextBox 초기화
                    extend_id.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a member is selected
                if (memberList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("삭제할 회원을 선택해주세요.");
                    return;
                }

                // Get the selected member's ID from the DataGridView
                string memberId = memberList.SelectedRows[0].Cells["member_id"].Value.ToString();

                // Delete the member from Firebase
                var response = await client.DeleteAsync("users/" + memberId);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("회원 정보가 삭제되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
