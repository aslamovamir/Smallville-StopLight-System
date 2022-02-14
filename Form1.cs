using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //this static variable will help with the identification of the state of the system, it will
        //help us switch between different states. This variable will correspond to each state that defines
        //which stoplight to turn to what light. By default, the state is 1, in which all the first stoplight
        //are red. In total, there are 8 states.
        static int state = 1;


        //Method Name: Maunual_Switch
        //Description: this is a function to manually change the colours of the stoplights according to the current 
        //state of the whole system. The function will accept a parameter that will define in what direction to cycle:
        //either forward or backward
        public void Manual_Switch(string direction)
        {

            //now we check in what direction to cycle the state
            if (direction == "forward")
            {
                //we will use modulo operation to keep that state in the range: 1 to 8
                //because we have 8 sates in total
                state = (state + 1) % 9;
                if (state == 0)
                {
                    state = 1;
                }
            }
            else
            {
                //we simply decrement the state back, but if we currently are in state 1, we reset back to 1
                if (state > 1)
                {
                    state--;
                }
            }

            MessageBox.Show("CURRENT STATE: " + state);

            //now we check the state and correspondingly change the colors of the stoplight objects
            //state 1: north and south lights are red, east and west lights are green
            if (state == 1)
            {
                //change the colour of the object
                north_light.ChangeColor("red");
                //now change the colour of the correspnding box on the form
                North_Light1_BX.BackColor = Color.Red;

                //top light of the South Stoplight station
                south_light.ChangeColor("red");
                //now change the colour of the correspnding box on the form
                South_Light1_BX.BackColor = Color.Red;

                //top light of the East Stoplight station
                east_light.ChangeColor("green");
                //now change the colour of the correspnding box on the form
                East_Light1_BX.BackColor = Color.Green;

                //top light of the West Stoplight station
                west_light.ChangeColor("green");
                //now change the colour of the correspnding box on the form
                West_Light1_BX.BackColor = Color.Green;
            }
            //state 2: all the light are red
            else if (state == 2)
            {
                //top light of the North Stoplight station
                north_light.ChangeColor("red");
                //now change the colour of the correspnding box on the form
                North_Light1_BX.BackColor = Color.Red;

                //top light of the South Stoplight station
                south_light.ChangeColor("red");
                South_Light1_BX.BackColor = Color.Red;

                //top light of the East Stoplight station
                east_light.ChangeColor("red");
                East_Light1_BX.BackColor = Color.Red;

                //top light of the West Stoplight station
                west_light.ChangeColor("red");
                West_Light1_BX.BackColor = Color.Red;
            }
            //sate 3: north light green, the rest stay at their previous colour
            else if (state == 3)
            {
                //top light of the North Stoplight station
                north_light.ChangeColor("green");
                //now change the colour of the correspnding box on the form
                North_Light1_BX.BackColor = Color.Green;

                //change the colours of all the stoplights to the colours of the objects

                //south stoplight
                south_light.ChangeColor("red");
                South_Light1_BX.BackColor = Color.Red;

                //east stoplight
                east_light.ChangeColor("red");
                East_Light1_BX.BackColor = Color.Red;

                //west stoplight
                west_light.ChangeColor("red");
                West_Light1_BX.BackColor = Color.Red;
            }
            //state 4: turn the south light green, the rest stay the same
            else if (state == 4)
            {
                //change the south light to green color
                south_light.ChangeColor("green");
                //now change the colour of the correspnding box on the form
                South_Light1_BX.BackColor = Color.Green;

                //change the colors of the rest to the colours of the corresponding objects

                //north stoplight
                north_light.ChangeColor("green");
                North_Light1_BX.BackColor = Color.Green;

                //east stoplight
                east_light.ChangeColor("red");
                East_Light1_BX.BackColor = Color.Red;

                //west stoplight
                west_light.ChangeColor("red");
                West_Light1_BX.BackColor = Color.Red;
            }
            //state 5: turn the north and south lights red, the rest stay the same
            else if (state == 5)
            {
                //top light of the North Stoplight station turned red
                north_light.ChangeColor("red");
                //now change the colour of the correspnding box on the form
                North_Light1_BX.BackColor = Color.Red;

                //top light of the South Stoplight turned red
                south_light.ChangeColor("red");
                South_Light1_BX.BackColor = Color.Red;

                //east stoplight
                east_light.ChangeColor("red");
                East_Light1_BX.BackColor = Color.Red;

                //west stoplight
                west_light.ChangeColor("red");
                West_Light1_BX.BackColor = Color.Red;
            }
            //state 6: turn the east light green, the rest stay the same
            else if (state == 6)
            { 
                //east stoplight turned green
                east_light.ChangeColor("green");
                //now change the colour of the correspnding box on the form
                East_Light1_BX.BackColor = Color.Green;

                //north stoplight
                north_light.ChangeColor("red");
                North_Light1_BX.BackColor = Color.Red;

                //south stoplight
                south_light.ChangeColor("red");
                South_Light1_BX.BackColor = Color.Red;

                //west stoplight
                west_light.ChangeColor("red");
                West_Light1_BX.BackColor = Color.Red;
            }
            //state 7: turn the west light green, the rest stay the same
            else if (state == 7)
            { 
                //the west stoplight turned green
                west_light.ChangeColor("green");
                West_Light1_BX.BackColor = Color.Green;

                //north stoplight
                north_light.ChangeColor("red");
                North_Light1_BX.BackColor = Color.Red;
                 

                //south stoplight
                south_light.ChangeColor("red");
                South_Light1_BX.BackColor = Color.Red;

                //east stoplight
                east_light.ChangeColor("green");
                East_Light1_BX.BackColor = Color.Green;
            }
            //state 8: turn both the east and west lights red, the rest stay the same
            else
            {
                //the east stoplight turned red
                east_light.ChangeColor("red");
                //now change the colour of the correspnding box on the form
                East_Light1_BX.BackColor = Color.Red;

                //the west stoplight turned red
                west_light.ChangeColor("red");
                //now change the colour of the correspnding box on the form
                West_Light1_BX.BackColor = Color.Red;

                //north stoplight
                north_light.ChangeColor("red");
                North_Light1_BX.BackColor = Color.Red;

                //south stoplight
                south_light.ChangeColor("red");
                South_Light1_BX.BackColor = Color.Red;
            }

            //print the colours of the stoplights
            Console.WriteLine("\n\nCURRENT STATE: " + state);
            Console.WriteLine("\nNorth light: " + north_light.GetColour());
            Console.WriteLine("South light: " + south_light.GetColour());
            Console.WriteLine("East light: " + east_light.GetColour());
            Console.WriteLine("West light: " + west_light.GetColour());
        }


        public Form1()
        {
            InitializeComponent();
        }
        //Let's create stoplight objects for the 4 stoplight stations

        //north stoplights
        Stoplight north_light = new Stoplight();

        //south stoplights
        Stoplight south_light = new Stoplight();

        //east stoplights
        Stoplight east_light = new Stoplight();

        //west stoplights
        Stoplight west_light = new Stoplight();

        
        //Method Name: Forward_BTN_Click
        //Description: this is a private method of the Forward button: when the user clicks on that button,
        //this function will handle the event, and will call another helper function: Manual Switch.
        private void Forward_BTN_Click(object sender, EventArgs e)
        {
            //call the helper function Manual_Switch to cycle the system state forwards
            Manual_Switch("forward");
        }

        //Method Name: Backward_BTN_Click
        //Description: this is a private method of the Backward button: when the user clicks on that button,
        //this function will handle the event, and will call another helper function: Manual Switch.
        private void Backward_BTN_Click(object sender, EventArgs e)
        {
            //call the helper function Manual_Switch to cycle the system backwards
            Manual_Switch("backwards");
        }
    }
}
