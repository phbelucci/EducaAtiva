﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameLearning
{
    public partial class telaPontuacao : Form
    {
        private string cod_user;

        public telaPontuacao(string cod_user)
        {
            InitializeComponent();
            this.cod_user = cod_user;
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            telaManterExercicios manterExercicio = new telaManterExercicios(cod_user);
            manterExercicio.Closed += (s, args) => this.Close();
            manterExercicio.Show();
        }
    }
}
