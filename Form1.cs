namespace ahorcado
{
    public partial class Form1 : Form
    {



        //declaro variables que contabiliza los errores 

        int fallar;
        int numero ;
        int cuenta = 0;
        public Form1()
        {


           
             numero = 1;

            InitializeComponent();
            ganar(cuenta,numero);
            juego(numero);


            lblnumerojuego.Text = numero.ToString();


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        //BOTONES 


        // FUNCION DEL BOTON 1 
        private void btn1_Click(object sender, EventArgs e)
        {

            numero = int.Parse(lblnumerojuego.Text);

            switch (numero)
            {

                case 1:
                    btn1.BackColor = Color.Red;
                    btn1.Enabled = false;
                    fallar++;

                    falla(fallar);

                    juegoperdido(fallar);


                    break;

                case 2:

                    if (txtprimero.Text == "")
                    {

                        txtprimero.Text = "C";


                    }else
                    {
                        txttercero.Text = "C";

                    }

                    btn1.BackColor = Color.DarkGreen;
                    btn1.Enabled = false;

                    cuenta++;
                    ganar(cuenta, numero);
                    btn1.BackColor = Color.DarkGreen;
                    btn1.Enabled = false;


                    break;


                default:
                    break;
            }


        }


        // FUNCION DEL BOTON 2
        private void btn2_Click(object sender, EventArgs e)
        {

            numero = int.Parse(lblnumerojuego.Text);



            switch (numero)
            {

                case 1:

                if(txtsegundo.Text == "")
                    {
                        txtsegundo.Text = "G";
                       

                    }

                    btn2.BackColor = Color.DarkGreen;
                    btn2.Enabled = false;

                    cuenta++;
                    ganar(cuenta, numero);

                  


                    break;

                case 2:

                    fallar++;

                    falla(fallar);

                    juegoperdido(fallar);
                    btn2.BackColor = Color.Red;
                    btn2.Enabled = false;
                    break;

            }
            

        }

        // FUNCION DEL BOTON 3
        private void btn3_Click(object sender, EventArgs e)
        {






            numero = int.Parse(lblnumerojuego.Text);



            switch (numero)
            {

                case 1:

                    if (txtprimero.Text == "")
                    {

                        txtprimero.Text = "A";


                    }
                    else
                    {

                        txtcuarto.Text = "A";


                    }
                    btn3.BackColor = Color.DarkGreen;
                    btn3.Enabled = false;

                    cuenta++;
                    ganar(cuenta, numero);
                  


                    break;

                case 2:
                    btn3.BackColor = Color.Red;
                    btn3.Enabled = false;
                    fallar++;

                    falla(fallar);

                    juegoperdido(fallar);

                    break;

            }
           
           
        }

        // FUNCION DEL BOTON 4
        private void btn4_Click(object sender, EventArgs e)
        {
           

            numero = int.Parse(lblnumerojuego.Text);



            switch (numero)
            {

                case 1:
                    fallar++;

                    falla(fallar);

                    juegoperdido(fallar);

                   btn4.BackColor = Color.Red;
                    btn4.Enabled = false;
                    break;

                case 2:

                    if (txtsegundo.Text == "")
                    {

                        txtsegundo.Text = "O";


                    }
                    else 
                    {
                        txtcuarto.Text = "O";

                    }

                    btn4.BackColor = Color.DarkGreen;
                    btn4.Enabled = false;

                    cuenta++;
                    ganar(cuenta, numero);

                   

                    break;

            }

        }


        // FUNCION DEL BOTON 5
        private void btn5_Click(object sender, EventArgs e)
        {



            numero = int.Parse(lblnumerojuego.Text);



            switch (numero)
            {

                case 1:

                    if (txttercero.Text == "")
                    {

                        txttercero.Text = "U";


                    }

                    btn5.BackColor = Color.DarkGreen;
                    btn5.Enabled = false;

                    cuenta++;
                    ganar(cuenta, numero);

               

                    break;

                case 2:

                    if (txtsegundo.Text == "")
                    {

                        txtsegundo.Text = "O";


                    }else
                    {
                        txtcuarto.Text = "O";
                    }


                    btn5.BackColor = Color.DarkGreen;
                    btn5.Enabled = false;

                    cuenta++;
                    ganar(cuenta, numero);


                    break;

            }

          
        }


        // FUNCION DEL BOTON 6
        private void btn6_Click(object sender, EventArgs e)
        {



            numero = int.Parse(lblnumerojuego.Text);



            switch (numero)
            {


                // juego 1 boton 6
                case 1:
                    btn6.BackColor = Color.Red;
                    btn6.Enabled = false;

                    fallar++;

                    falla(fallar);

                    juegoperdido(fallar);

                    break;

                // juego 2 boton 6
                case 2:
                    btn6.BackColor = Color.Red;
                    btn6.Enabled = false;

                    fallar++;

                    falla(fallar);

                    juegoperdido(fallar);

                    break;

            }

            

        }




        // FUNCION DEL BOTON 7

        private void btn7_Click(object sender, EventArgs e)
        {



            numero = int.Parse(lblnumerojuego.Text);



            switch (numero)
            {


                // juego 1 boton 7
                case 1:


                    if (txtprimero.Text == "")
                    {

                        txtprimero.Text = "A";


                    }
                    else
                    {

                        txtcuarto.Text = "A";


                    }

                    btn7.BackColor = Color.DarkGreen;
                    btn7.Enabled = false;

                    cuenta++;
                    ganar(cuenta, numero);

                   


                    break;

                // juego 2 boton 7
                case 2:

                    if (txtprimero.Text == "")
                    {

                        txtprimero.Text = "C";


                    }
                    else
                    {

                        txttercero.Text = "C";


                    }

                    btn7.BackColor = Color.DarkGreen;
                    btn7.Enabled = false;

                    cuenta++;
                    ganar(cuenta, numero);


                    
                    break;

            }


        }




        private void lblnumerojuego_Click(object sender, EventArgs e)
        {

        }


        // funcion boton pista
        private void btnpista_Click(object sender, EventArgs e)
        {
            switch (lblnumerojuego.Text)
            {
                case "1":
                    txtpista.Text = "El 85% de nuestro cuerpo esta compuesto de eso";
                    break;

                case "2":
                    txtpista.Text = "Es una fruta que es gruesa por fuera y contiene agua por dentro";
                    break;

                case "3":
                    txtpista.Text = "El 85% de nuestro cuerpo esta compuesto de eso";
                    break;
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
           

            
        }



        public void atras (ref int a)
        {


            if (a == 1)
            {

                MessageBox.Show("No puede retroceder", "Nivel 1", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                a = a-1;
            }

        }



        //FUNCIONES 




        // ESTA FUNCION ES PARA PRESENTAR DE MANERA AUTOMATICA LAS LETRAS DE CADA JUEGO
        public void juego(int numero)
        {



            switch (numero)
            {

                //EJECUCION DEL PRIMER JUEGO 
                case 1:
                    btn1.Text = "H";
                    btn2.Text = "G";
                    btn3.Text = "A";
                    btn4.Text = "S";
                    btn5.Text = "U";
                    btn6.Text = "R";
                    btn7.Text = "A";


                    pxbox1.Visible = true;
                    pxbox2.Visible = false;
                    pxbox3.Visible = false;
                    pxbox4.Visible = false;
                    pxbox5.Visible = false;
                    pxbox6.Visible = false;

                    txtcero.Visible = false;
                    txtprimero.Visible = true;
                    txtsegundo.Visible = true;
                    txttercero.Visible = true;
                    txtcuarto.Visible = true;
                    txtcinco.Visible = false;




                    break;

                case 2:

                    btn1.Text = "C";
                    btn2.Text = "P";
                    btn3.Text = "A";
                    btn4.Text = "O";
                    btn5.Text = "O";
                    btn6.Text = "T";
                    btn7.Text = "C";

                    /*
                    pxbox1.Visible = true;
                    pxbox2.Visible = false;
                    pxbox3.Visible = false;
                    pxbox4.Visible = false;
                    pxbox5.Visible = false;
                    pxbox6.Visible = false;
                    */


                    txtcero.Visible = false;
                    txtprimero.Visible = true;
                    txtsegundo.Visible = true;
                    txttercero.Visible = true;
                    txtcuarto.Visible = true;
                    txtcinco.Visible = false;

                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;

                    btn1.BackColor = Color.White;
                    btn2.BackColor = Color.White;
                    btn3.BackColor = Color.White;
                    btn4.BackColor = Color.White;
                    btn5.BackColor = Color.White;
                    btn6.BackColor = Color.White;
                    btn7.BackColor = Color.White;

                    break;

                case 3:


                    btn1.Text = "T";
                    btn2.Text = "A";
                    btn3.Text = "A";
                    btn4.Text = "B";
                    btn5.Text = "O";
                    btn6.Text = "T";
                    btn7.Text = "E";


                    pxbox1.Visible = true;
                    pxbox2.Visible = false;
                    pxbox3.Visible = false;
                    pxbox4.Visible = false;
                    pxbox5.Visible = false;
                    pxbox6.Visible = false;

                    txtcero.Visible = false;
                    txtprimero.Visible = true;
                    txtsegundo.Visible = true;
                    txttercero.Visible = true;
                    txtcuarto.Visible = true;
                    txtcinco.Visible = false;

                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;

                    btn1.BackColor = Color.White;
                    btn2.BackColor = Color.White;
                    btn3.BackColor = Color.White;
                    btn4.BackColor = Color.White;
                    btn5.BackColor = Color.White;
                    btn6.BackColor = Color.White;
                    btn7.BackColor = Color.White;

                    break;

                case 4:

                    break;

                case 5:

                    break;

            }
        }


        // FUNCION PARA VER SI SE HA GANADO EL JUEGO
        public void ganar(int cuenta, int numero )
        {
            numero = Convert.ToInt16(lblnumerojuego.Text);
  

            // VERICA SI EL TOTAL DEL CONTADOR ES IGUAL A 4 SE HA GANADO EL PRIMER JUEGO 
            if (cuenta == 4)
            {
                MessageBox.Show("Has Ganado el  Juego", "Juego Ganado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numero++;
                limpiar();
                // Verifica si hay más juegos disponibles
                if (numero <= 5) // Cambia el 5 al número total de juegos
                {
                    // Configura el siguiente juego
                    juego(numero);

                    // Actualiza el texto del label para mostrar el nuevo número de juego
                    lblnumerojuego.Text = numero.ToString();
                    

                }
                
                /*else
                {
                    Has ganado todos los juegos, puedes mostrar un mensaje de victoria final o reiniciar el juego, según lo que desees.
                    MessageBox.Show("¡Has ganado todos los juegos!", "Victoria Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                */
            }
            else if (cuenta == 8)
            {
                MessageBox.Show("Has Ganado el  Juego", "Juego Ganado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numero++;
                limpiar();
                // Verifica si hay más juegos disponibles
                if (numero <= 5) // Cambia el 5 al número total de juegos
                {
                    // Configura el siguiente juego
                    juego(numero);

                    // Actualiza el texto del label para mostrar el nuevo número de juego
                    lblnumerojuego.Text = numero.ToString();


                }
              
            }


        }


        //funcion para limpiar
        public void limpiar()
        {
            txtprimero.Clear();
            txtsegundo.Clear();
            txttercero.Clear();
            txtcuarto.Clear();
        }


        // funcion que muestra la imagen del ahorcado por cada vez que el usuario no acierte 
        public void falla(int a)
        {
            switch (a)
            {
                case 1:
                    MessageBox.Show(" La Letra seleccionada es inccorecta ", " Letra equivocada",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    pxbox1.Visible = false;
                    pxbox2.Visible = true;
                    pxbox3.Visible = false;
                    pxbox4.Visible = false;
                    pxbox5.Visible = false;
                    pxbox6.Visible = false;
                    break;

                case 2:
                    MessageBox.Show(" La Letra seleccionada es inccorecta ", " Letra equivocada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pxbox1.Visible = false;
                    pxbox2.Visible = false;
                    pxbox3.Visible = true;
                    pxbox4.Visible = false;
                    pxbox5.Visible = false;
                    pxbox6.Visible = false;
                    break;

                case 3:
                    MessageBox.Show(" La Letra seleccionada es inccorecta ", " Letra equivocada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pxbox1.Visible = false;
                    pxbox2.Visible = false;
                    pxbox3.Visible = false;
                    pxbox4.Visible = true;
                    pxbox5.Visible = false;
                    pxbox6.Visible = false;
                    break;


                case 4:
                    MessageBox.Show(" La Letra seleccionada es inccorecta ", " Letra equivocada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pxbox1.Visible = false;
                    pxbox2.Visible = false;
                    pxbox3.Visible = false;
                    pxbox4.Visible = false;
                    pxbox5.Visible = true;
                    pxbox6.Visible = false;
                    break;

                case 5:
                    MessageBox.Show(" La Letra seleccionada es inccorecta ", " Letra equivocada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pxbox1.Visible = false;
                    pxbox2.Visible = false;
                    pxbox3.Visible = false;
                    pxbox4.Visible = false;
                    pxbox5.Visible = false;
                    pxbox6.Visible = true;
                    break;


            }
        }


        //funcion para evaluar si ha perdido el juego
        public void juegoperdido(int a)
        {
            if (a == 5)
            {
                MessageBox.Show(" Has sido ahorcado");
                pxbox1.Visible = false;
                pxbox2.Visible = true;
                pxbox3.Visible = false;
                pxbox4.Visible = false;
                pxbox5.Visible = false;
                pxbox6.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            //lbltimer.Text = DateTime.Now.ToLongTimeString();


            int tiempo = 40;
            while (tiempo > 5)
            {
                lbltimer.Text = tiempo.ToString();
                tiempo = tiempo - 1;

            }





        }

       
    }




}