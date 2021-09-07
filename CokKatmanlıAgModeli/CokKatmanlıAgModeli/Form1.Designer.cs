namespace CokKatmanlıAgModeli
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbGiris2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblOgrenmeKatsayisi = new System.Windows.Forms.Label();
            this.tbOgrenmeKatsayisi = new System.Windows.Forms.TextBox();
            this.tbmomentum = new System.Windows.Forms.TextBox();
            this.btnOrEgit = new System.Windows.Forms.Button();
            this.btnAndEgit = new System.Windows.Forms.Button();
            this.btnXorEgit = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGiris1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestEt = new System.Windows.Forms.Button();
            this.lbl3Cikis = new System.Windows.Forms.Label();
            this.lbl2Cikis = new System.Windows.Forms.Label();
            this.lbl1Cikis = new System.Windows.Forms.Label();
            this.lblEsik2 = new System.Windows.Forms.Label();
            this.lblEsik1 = new System.Windows.Forms.Label();
            this.lblGiris2 = new System.Windows.Forms.Label();
            this.lblGiris1 = new System.Windows.Forms.Label();
            this.lblWe2_C1 = new System.Windows.Forms.Label();
            this.lblW2_C1 = new System.Windows.Forms.Label();
            this.lblW1_C1 = new System.Windows.Forms.Label();
            this.lblWe1A1 = new System.Windows.Forms.Label();
            this.lblWe1A2 = new System.Windows.Forms.Label();
            this.lblW2A2 = new System.Windows.Forms.Label();
            this.lblW2A1 = new System.Windows.Forms.Label();
            this.lblW1A2 = new System.Windows.Forms.Label();
            this.lblW1A1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGiris2
            // 
            this.tbGiris2.Location = new System.Drawing.Point(142, 78);
            this.tbGiris2.MaxLength = 1;
            this.tbGiris2.Name = "tbGiris2";
            this.tbGiris2.Size = new System.Drawing.Size(49, 21);
            this.tbGiris2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblOgrenmeKatsayisi);
            this.groupBox2.Controls.Add(this.tbOgrenmeKatsayisi);
            this.groupBox2.Controls.Add(this.tbmomentum);
            this.groupBox2.Controls.Add(this.btnOrEgit);
            this.groupBox2.Controls.Add(this.btnAndEgit);
            this.groupBox2.Controls.Add(this.btnXorEgit);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 144);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tüm Veriler İçin Ağı Eğit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Momentum:";
            // 
            // lblOgrenmeKatsayisi
            // 
            this.lblOgrenmeKatsayisi.AutoSize = true;
            this.lblOgrenmeKatsayisi.Location = new System.Drawing.Point(11, 28);
            this.lblOgrenmeKatsayisi.Name = "lblOgrenmeKatsayisi";
            this.lblOgrenmeKatsayisi.Size = new System.Drawing.Size(94, 13);
            this.lblOgrenmeKatsayisi.TabIndex = 55;
            this.lblOgrenmeKatsayisi.Text = "Öğrenme Katsayısı";
            // 
            // tbOgrenmeKatsayisi
            // 
            this.tbOgrenmeKatsayisi.Location = new System.Drawing.Point(113, 28);
            this.tbOgrenmeKatsayisi.Name = "tbOgrenmeKatsayisi";
            this.tbOgrenmeKatsayisi.Size = new System.Drawing.Size(69, 20);
            this.tbOgrenmeKatsayisi.TabIndex = 46;
            this.tbOgrenmeKatsayisi.Text = "0,6";
            // 
            // tbmomentum
            // 
            this.tbmomentum.Location = new System.Drawing.Point(113, 54);
            this.tbmomentum.Name = "tbmomentum";
            this.tbmomentum.Size = new System.Drawing.Size(69, 20);
            this.tbmomentum.TabIndex = 45;
            this.tbmomentum.Text = "0,2";
            // 
            // btnOrEgit
            // 
            this.btnOrEgit.BackColor = System.Drawing.Color.Indigo;
            this.btnOrEgit.Location = new System.Drawing.Point(79, 87);
            this.btnOrEgit.Name = "btnOrEgit";
            this.btnOrEgit.Size = new System.Drawing.Size(59, 46);
            this.btnOrEgit.TabIndex = 26;
            this.btnOrEgit.Text = "OR ";
            this.btnOrEgit.UseVisualStyleBackColor = false;
            this.btnOrEgit.Click += new System.EventHandler(this.btnOrEgit_Click);
            // 
            // btnAndEgit
            // 
            this.btnAndEgit.BackColor = System.Drawing.Color.Indigo;
            this.btnAndEgit.Location = new System.Drawing.Point(144, 87);
            this.btnAndEgit.Name = "btnAndEgit";
            this.btnAndEgit.Size = new System.Drawing.Size(59, 46);
            this.btnAndEgit.TabIndex = 25;
            this.btnAndEgit.Text = "AND ";
            this.btnAndEgit.UseVisualStyleBackColor = false;
            this.btnAndEgit.Click += new System.EventHandler(this.btnAndEgit_Click);
            // 
            // btnXorEgit
            // 
            this.btnXorEgit.BackColor = System.Drawing.Color.Indigo;
            this.btnXorEgit.Location = new System.Drawing.Point(14, 87);
            this.btnXorEgit.Name = "btnXorEgit";
            this.btnXorEgit.Size = new System.Drawing.Size(59, 46);
            this.btnXorEgit.TabIndex = 24;
            this.btnXorEgit.Text = "XOR ";
            this.btnXorEgit.UseVisualStyleBackColor = false;
            this.btnXorEgit.Click += new System.EventHandler(this.btnXorEgit_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(3, 30);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(200, 13);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Eğitilen ağın testini buradan yapabilirsiniz.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Gold;
            this.label13.Location = new System.Drawing.Point(579, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "A2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(769, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Ç1";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(297, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "G2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(297, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "G1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(761, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 26);
            this.label8.TabIndex = 77;
            this.label8.Text = "Çıktı \nKatmanı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(562, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 26);
            this.label7.TabIndex = 76;
            this.label7.Text = "Ara \r\nKatmanı";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(284, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 26);
            this.label6.TabIndex = 75;
            this.label6.Text = "Girdi \r\nKatmanı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(608, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Eşik Değeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(406, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Eşik Değeri";
            // 
            // tbGiris1
            // 
            this.tbGiris1.Location = new System.Drawing.Point(40, 78);
            this.tbGiris1.MaxLength = 1;
            this.tbGiris1.Name = "tbGiris1";
            this.tbGiris1.Size = new System.Drawing.Size(49, 21);
            this.tbGiris1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gold;
            this.label12.Location = new System.Drawing.Point(579, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "A1";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblAciklama);
            this.groupBox3.Controls.Add(this.tbGiris2);
            this.groupBox3.Controls.Add(this.tbGiris1);
            this.groupBox3.Controls.Add(this.btnTestEt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 171);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eğitilen Ağı Test Et";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "G2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "G1:";
            // 
            // btnTestEt
            // 
            this.btnTestEt.BackColor = System.Drawing.Color.Indigo;
            this.btnTestEt.Location = new System.Drawing.Point(14, 112);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(185, 36);
            this.btnTestEt.TabIndex = 0;
            this.btnTestEt.Text = "Ağı Test Et";
            this.btnTestEt.UseVisualStyleBackColor = false;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // lbl3Cikis
            // 
            this.lbl3Cikis.AutoSize = true;
            this.lbl3Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3Cikis.ForeColor = System.Drawing.Color.Transparent;
            this.lbl3Cikis.Location = new System.Drawing.Point(754, 147);
            this.lbl3Cikis.Name = "lbl3Cikis";
            this.lbl3Cikis.Size = new System.Drawing.Size(52, 13);
            this.lbl3Cikis.TabIndex = 70;
            this.lbl3Cikis.Text = "0.000000";
            // 
            // lbl2Cikis
            // 
            this.lbl2Cikis.AutoSize = true;
            this.lbl2Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2Cikis.ForeColor = System.Drawing.Color.White;
            this.lbl2Cikis.Location = new System.Drawing.Point(562, 213);
            this.lbl2Cikis.Name = "lbl2Cikis";
            this.lbl2Cikis.Size = new System.Drawing.Size(52, 13);
            this.lbl2Cikis.TabIndex = 69;
            this.lbl2Cikis.Text = "0.000000";
            // 
            // lbl1Cikis
            // 
            this.lbl1Cikis.AutoSize = true;
            this.lbl1Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1Cikis.ForeColor = System.Drawing.Color.White;
            this.lbl1Cikis.Location = new System.Drawing.Point(562, 99);
            this.lbl1Cikis.Name = "lbl1Cikis";
            this.lbl1Cikis.Size = new System.Drawing.Size(52, 13);
            this.lbl1Cikis.TabIndex = 68;
            this.lbl1Cikis.Text = "0.000000";
            // 
            // lblEsik2
            // 
            this.lblEsik2.AutoSize = true;
            this.lblEsik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEsik2.Location = new System.Drawing.Point(628, 313);
            this.lblEsik2.Name = "lblEsik2";
            this.lblEsik2.Size = new System.Drawing.Size(17, 18);
            this.lblEsik2.TabIndex = 67;
            this.lblEsik2.Text = "1";
            // 
            // lblEsik1
            // 
            this.lblEsik1.AutoSize = true;
            this.lblEsik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEsik1.Location = new System.Drawing.Point(427, 313);
            this.lblEsik1.Name = "lblEsik1";
            this.lblEsik1.Size = new System.Drawing.Size(17, 18);
            this.lblEsik1.TabIndex = 66;
            this.lblEsik1.Text = "1";
            // 
            // lblGiris2
            // 
            this.lblGiris2.AutoSize = true;
            this.lblGiris2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris2.Location = new System.Drawing.Point(297, 213);
            this.lblGiris2.Name = "lblGiris2";
            this.lblGiris2.Size = new System.Drawing.Size(14, 13);
            this.lblGiris2.TabIndex = 65;
            this.lblGiris2.Text = "0";
            // 
            // lblGiris1
            // 
            this.lblGiris1.AutoSize = true;
            this.lblGiris1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris1.Location = new System.Drawing.Point(297, 111);
            this.lblGiris1.Name = "lblGiris1";
            this.lblGiris1.Size = new System.Drawing.Size(14, 13);
            this.lblGiris1.TabIndex = 64;
            this.lblGiris1.Text = "0";
            // 
            // lblWe2_C1
            // 
            this.lblWe2_C1.AutoSize = true;
            this.lblWe2_C1.Location = new System.Drawing.Point(685, 222);
            this.lblWe2_C1.Name = "lblWe2_C1";
            this.lblWe2_C1.Size = new System.Drawing.Size(46, 13);
            this.lblWe2_C1.TabIndex = 63;
            this.lblWe2_C1.Text = "We2-Ç1";
            // 
            // lblW2_C1
            // 
            this.lblW2_C1.AutoSize = true;
            this.lblW2_C1.Location = new System.Drawing.Point(677, 174);
            this.lblW2_C1.Name = "lblW2_C1";
            this.lblW2_C1.Size = new System.Drawing.Size(54, 13);
            this.lblW2_C1.TabIndex = 62;
            this.lblW2_C1.Text = "G1W3-Ç1";
            // 
            // lblW1_C1
            // 
            this.lblW1_C1.AutoSize = true;
            this.lblW1_C1.Location = new System.Drawing.Point(677, 120);
            this.lblW1_C1.Name = "lblW1_C1";
            this.lblW1_C1.Size = new System.Drawing.Size(54, 13);
            this.lblW1_C1.TabIndex = 61;
            this.lblW1_C1.Text = "G1W3-Ç1";
            // 
            // lblWe1A1
            // 
            this.lblWe1A1.AutoSize = true;
            this.lblWe1A1.Location = new System.Drawing.Point(474, 207);
            this.lblWe1A1.Name = "lblWe1A1";
            this.lblWe1A1.Size = new System.Drawing.Size(46, 13);
            this.lblWe1A1.TabIndex = 60;
            this.lblWe1A1.Text = "We1-A1";
            // 
            // lblWe1A2
            // 
            this.lblWe1A2.AutoSize = true;
            this.lblWe1A2.Location = new System.Drawing.Point(487, 249);
            this.lblWe1A2.Name = "lblWe1A2";
            this.lblWe1A2.Size = new System.Drawing.Size(46, 13);
            this.lblWe1A2.TabIndex = 59;
            this.lblWe1A2.Text = "We1-A2";
            // 
            // lblW2A2
            // 
            this.lblW2A2.AutoSize = true;
            this.lblW2A2.Location = new System.Drawing.Point(390, 194);
            this.lblW2A2.Name = "lblW2A2";
            this.lblW2A2.Size = new System.Drawing.Size(54, 13);
            this.lblW2A2.TabIndex = 58;
            this.lblW2A2.Text = "G1W2-A2";
            // 
            // lblW2A1
            // 
            this.lblW2A1.AutoSize = true;
            this.lblW2A1.Location = new System.Drawing.Point(423, 147);
            this.lblW2A1.Name = "lblW2A1";
            this.lblW2A1.Size = new System.Drawing.Size(54, 13);
            this.lblW2A1.TabIndex = 57;
            this.lblW2A1.Text = "G1W2-A1";
            // 
            // lblW1A2
            // 
            this.lblW1A2.AutoSize = true;
            this.lblW1A2.Location = new System.Drawing.Point(390, 111);
            this.lblW1A2.Name = "lblW1A2";
            this.lblW1A2.Size = new System.Drawing.Size(54, 13);
            this.lblW1A2.TabIndex = 56;
            this.lblW1A2.Text = "G1W1-A2";
            // 
            // lblW1A1
            // 
            this.lblW1A1.AutoSize = true;
            this.lblW1A1.Location = new System.Drawing.Point(423, 89);
            this.lblW1A1.Name = "lblW1A1";
            this.lblW1A1.Size = new System.Drawing.Size(54, 13);
            this.lblW1A1.TabIndex = 55;
            this.lblW1A1.Text = "G1W1-A1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(855, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl3Cikis);
            this.Controls.Add(this.lbl2Cikis);
            this.Controls.Add(this.lbl1Cikis);
            this.Controls.Add(this.lblEsik2);
            this.Controls.Add(this.lblEsik1);
            this.Controls.Add(this.lblGiris2);
            this.Controls.Add(this.lblGiris1);
            this.Controls.Add(this.lblWe2_C1);
            this.Controls.Add(this.lblW2_C1);
            this.Controls.Add(this.lblW1_C1);
            this.Controls.Add(this.lblWe1A1);
            this.Controls.Add(this.lblWe1A2);
            this.Controls.Add(this.lblW2A2);
            this.Controls.Add(this.lblW2A1);
            this.Controls.Add(this.lblW1A2);
            this.Controls.Add(this.lblW1A1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGiris2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblOgrenmeKatsayisi;
        private System.Windows.Forms.TextBox tbOgrenmeKatsayisi;
        private System.Windows.Forms.TextBox tbmomentum;
        private System.Windows.Forms.Button btnOrEgit;
        private System.Windows.Forms.Button btnAndEgit;
        private System.Windows.Forms.Button btnXorEgit;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGiris1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTestEt;
        private System.Windows.Forms.Label lbl3Cikis;
        private System.Windows.Forms.Label lbl2Cikis;
        private System.Windows.Forms.Label lbl1Cikis;
        private System.Windows.Forms.Label lblEsik2;
        private System.Windows.Forms.Label lblEsik1;
        private System.Windows.Forms.Label lblGiris2;
        private System.Windows.Forms.Label lblGiris1;
        private System.Windows.Forms.Label lblWe2_C1;
        private System.Windows.Forms.Label lblW2_C1;
        private System.Windows.Forms.Label lblW1_C1;
        private System.Windows.Forms.Label lblWe1A1;
        private System.Windows.Forms.Label lblWe1A2;
        private System.Windows.Forms.Label lblW2A2;
        private System.Windows.Forms.Label lblW2A1;
        private System.Windows.Forms.Label lblW1A2;
        private System.Windows.Forms.Label lblW1A1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

