
namespace N게시_관리자
{
    partial class Form_admin
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.member_box = new System.Windows.Forms.GroupBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.memberList = new System.Windows.Forms.DataGridView();
            this.member_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_name = new System.Windows.Forms.Label();
            this.new_id = new System.Windows.Forms.Label();
            this.new_pw = new System.Windows.Forms.Label();
            this.join_id = new System.Windows.Forms.TextBox();
            this.join_name = new System.Windows.Forms.TextBox();
            this.join_pw = new System.Windows.Forms.TextBox();
            this.join_button = new System.Windows.Forms.Button();
            this.join_box = new System.Windows.Forms.GroupBox();
            this.extendDate = new System.Windows.Forms.GroupBox();
            this.extend_button = new System.Windows.Forms.Button();
            this.extend_id = new System.Windows.Forms.TextBox();
            this.date_id = new System.Windows.Forms.Label();
            this.member_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberList)).BeginInit();
            this.join_box.SuspendLayout();
            this.extendDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // member_box
            // 
            this.member_box.Controls.Add(this.delete_button);
            this.member_box.Controls.Add(this.search);
            this.member_box.Controls.Add(this.memberList);
            this.member_box.Location = new System.Drawing.Point(268, 18);
            this.member_box.Name = "member_box";
            this.member_box.Size = new System.Drawing.Size(572, 206);
            this.member_box.TabIndex = 4;
            this.member_box.TabStop = false;
            this.member_box.Text = "회원 목록";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(484, 178);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(82, 25);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "회원 삭제";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(388, 178);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(90, 25);
            this.search.TabIndex = 1;
            this.search.Text = "조회";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // memberList
            // 
            this.memberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.member_name,
            this.member_id,
            this.member_pw,
            this.ExpireDate});
            this.memberList.Location = new System.Drawing.Point(6, 27);
            this.memberList.Name = "memberList";
            this.memberList.RowTemplate.Height = 23;
            this.memberList.Size = new System.Drawing.Size(560, 149);
            this.memberList.TabIndex = 0;
            // 
            // member_name
            // 
            this.member_name.DataPropertyName = "member_name";
            this.member_name.HeaderText = "회원 이름";
            this.member_name.Name = "member_name";
            this.member_name.ReadOnly = true;
            // 
            // member_id
            // 
            this.member_id.DataPropertyName = "member_id";
            this.member_id.HeaderText = "아이디";
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            // 
            // member_pw
            // 
            this.member_pw.DataPropertyName = "member_pw";
            this.member_pw.HeaderText = "비밀번호";
            this.member_pw.Name = "member_pw";
            this.member_pw.ReadOnly = true;
            // 
            // ExpireDate
            // 
            this.ExpireDate.DataPropertyName = "ExpireDate";
            this.ExpireDate.HeaderText = "종료일자";
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.ReadOnly = true;
            this.ExpireDate.Width = 217;
            // 
            // new_name
            // 
            this.new_name.AutoSize = true;
            this.new_name.Location = new System.Drawing.Point(11, 33);
            this.new_name.Name = "new_name";
            this.new_name.Size = new System.Drawing.Size(53, 12);
            this.new_name.TabIndex = 0;
            this.new_name.Text = "회원이름";
            // 
            // new_id
            // 
            this.new_id.AutoSize = true;
            this.new_id.Location = new System.Drawing.Point(23, 74);
            this.new_id.Name = "new_id";
            this.new_id.Size = new System.Drawing.Size(41, 12);
            this.new_id.TabIndex = 0;
            this.new_id.Text = "아이디";
            // 
            // new_pw
            // 
            this.new_pw.AutoSize = true;
            this.new_pw.Location = new System.Drawing.Point(11, 119);
            this.new_pw.Name = "new_pw";
            this.new_pw.Size = new System.Drawing.Size(53, 12);
            this.new_pw.TabIndex = 0;
            this.new_pw.Text = "비밀번호";
            // 
            // join_id
            // 
            this.join_id.Location = new System.Drawing.Point(89, 71);
            this.join_id.Name = "join_id";
            this.join_id.Size = new System.Drawing.Size(130, 21);
            this.join_id.TabIndex = 1;
            // 
            // join_name
            // 
            this.join_name.Location = new System.Drawing.Point(89, 30);
            this.join_name.Name = "join_name";
            this.join_name.Size = new System.Drawing.Size(130, 21);
            this.join_name.TabIndex = 1;
            // 
            // join_pw
            // 
            this.join_pw.Location = new System.Drawing.Point(89, 116);
            this.join_pw.Name = "join_pw";
            this.join_pw.PasswordChar = '*';
            this.join_pw.Size = new System.Drawing.Size(130, 21);
            this.join_pw.TabIndex = 1;
            // 
            // join_button
            // 
            this.join_button.Location = new System.Drawing.Point(89, 163);
            this.join_button.Name = "join_button";
            this.join_button.Size = new System.Drawing.Size(130, 23);
            this.join_button.TabIndex = 2;
            this.join_button.Text = "회원가입";
            this.join_button.UseVisualStyleBackColor = true;
            this.join_button.Click += new System.EventHandler(this.join_button_Click);
            // 
            // join_box
            // 
            this.join_box.Controls.Add(this.join_button);
            this.join_box.Controls.Add(this.join_pw);
            this.join_box.Controls.Add(this.new_id);
            this.join_box.Controls.Add(this.new_name);
            this.join_box.Controls.Add(this.join_name);
            this.join_box.Controls.Add(this.new_pw);
            this.join_box.Controls.Add(this.join_id);
            this.join_box.Location = new System.Drawing.Point(12, 18);
            this.join_box.Name = "join_box";
            this.join_box.Size = new System.Drawing.Size(234, 206);
            this.join_box.TabIndex = 3;
            this.join_box.TabStop = false;
            this.join_box.Text = "회원가입";
            // 
            // extendDate
            // 
            this.extendDate.Controls.Add(this.extend_button);
            this.extendDate.Controls.Add(this.extend_id);
            this.extendDate.Controls.Add(this.date_id);
            this.extendDate.Location = new System.Drawing.Point(268, 233);
            this.extendDate.Name = "extendDate";
            this.extendDate.Size = new System.Drawing.Size(450, 39);
            this.extendDate.TabIndex = 5;
            this.extendDate.TabStop = false;
            this.extendDate.Text = "기간 연장";
            // 
            // extend_button
            // 
            this.extend_button.Location = new System.Drawing.Point(333, 11);
            this.extend_button.Name = "extend_button";
            this.extend_button.Size = new System.Drawing.Size(99, 23);
            this.extend_button.TabIndex = 2;
            this.extend_button.Text = "연장";
            this.extend_button.UseVisualStyleBackColor = true;
            this.extend_button.Click += new System.EventHandler(this.extend_button_Click);
            // 
            // extend_id
            // 
            this.extend_id.Location = new System.Drawing.Point(168, 12);
            this.extend_id.Name = "extend_id";
            this.extend_id.Size = new System.Drawing.Size(148, 21);
            this.extend_id.TabIndex = 1;
            // 
            // date_id
            // 
            this.date_id.AutoSize = true;
            this.date_id.Location = new System.Drawing.Point(99, 15);
            this.date_id.Name = "date_id";
            this.date_id.Size = new System.Drawing.Size(41, 12);
            this.date_id.TabIndex = 0;
            this.date_id.Text = "아이디";
            // 
            // Form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 283);
            this.Controls.Add(this.extendDate);
            this.Controls.Add(this.member_box);
            this.Controls.Add(this.join_box);
            this.Name = "Form_admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_admin_Load);
            this.member_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberList)).EndInit();
            this.join_box.ResumeLayout(false);
            this.join_box.PerformLayout();
            this.extendDate.ResumeLayout(false);
            this.extendDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox member_box;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label new_name;
        private System.Windows.Forms.Label new_id;
        private System.Windows.Forms.Label new_pw;
        private System.Windows.Forms.TextBox join_id;
        private System.Windows.Forms.TextBox join_name;
        private System.Windows.Forms.TextBox join_pw;
        private System.Windows.Forms.Button join_button;
        private System.Windows.Forms.GroupBox join_box;
        private System.Windows.Forms.DataGridView memberList;
        private System.Windows.Forms.GroupBox extendDate;
        private System.Windows.Forms.Label date_id;
        private System.Windows.Forms.TextBox extend_id;
        private System.Windows.Forms.Button extend_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_pw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.Button delete_button;
    }
}

