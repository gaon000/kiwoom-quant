
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_button = new System.Windows.Forms.Button();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockcode_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stockname_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(27, 12);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(120, 43);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "로그인";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(66, 260);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(27, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "종목코드";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stockcode_textbox
            // 
            this.stockcode_textbox.Location = new System.Drawing.Point(392, 9);
            this.stockcode_textbox.Name = "stockcode_textbox";
            this.stockcode_textbox.Size = new System.Drawing.Size(100, 28);
            this.stockcode_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "종목명";
            // 
            // stockname_label
            // 
            this.stockname_label.AutoSize = true;
            this.stockname_label.Location = new System.Drawing.Point(389, 40);
            this.stockname_label.Name = "stockname_label";
            this.stockname_label.Size = new System.Drawing.Size(0, 27);
            this.stockname_label.TabIndex = 6;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(519, 9);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(81, 49);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "조회";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.stockname_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockcode_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.login_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stockcode_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stockname_label;
        private System.Windows.Forms.Button search_button;
    }
}

