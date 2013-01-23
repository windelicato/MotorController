#template(Simple);

String input = "5";
int speed = 0;
bool again = true;

Output.WriteLine("+-----------------------------+");
Output.WriteLine("| 				|");
Output.WriteLine("|   ZABER MOTOR CONTROLLER  	|");
Output.WriteLine("| 		V2.0		|");
Output.WriteLine("| 				|");
Output.WriteLine("| 				|");
Output.WriteLine("| 				|");
Output.WriteLine("| 				|");
Output.WriteLine("| 				|");
Output.WriteLine("| Press enter to continue...  |");
Output.WriteLine("+-----------------------------+");
Input.ReadLine();
Output.WriteLine("Please enter a speed in mm/s ");
input = Input.ReadLine();
speed = Convert.ToInt32(Convert.ToDouble(input)/(9.375*(0.49609375/1000)));

while(again){

	Output.WriteLine("+-----------------------------+");
	Output.WriteLine("| Options:			|");
	Output.WriteLine("| 				|");
	Output.WriteLine("| 1) Forwards at {0} mm/s 	|",input);
	Output.WriteLine("| 2) Backward at {0} mm/s 	|",input);
	Output.WriteLine("| 3) Send Home 		|");
	Output.WriteLine("| 4) Change Speed 		|");
	Output.WriteLine("| 0) QUIT 			|");
	Output.WriteLine("| 				|");
	Output.WriteLine("+-----------------------------+");
	Output.WriteLine("");
	Output.WriteLine("  Selection: ");
	String s = Input.ReadLine();
	int n = Convert.ToInt32(s);

	switch(n){
		case 1:
		        Output.WriteLine("Ready to move. Press enter to begin");
		        Input.ReadLine();

		        Output.WriteLine("Moving at speed {0}", speed);
		        Output.WriteLine("Press enter to stop");

		        Conversation.Request(Command.MoveAtConstantSpeed, speed);
		        Input.ReadLine();
		        PortFacade.GetConversation(0).Request(Command.Stop);
			break;
		case 2:
		        Output.WriteLine("Ready to move. Press enter to begin");
		        Input.ReadLine();

		        Output.WriteLine("Moving at speed {0}",-speed);
		        Output.WriteLine("Press enter to stop");

		        Conversation.Request(Command.MoveAtConstantSpeed, -speed);
		        Input.ReadLine();
		        PortFacade.GetConversation(0).Request(Command.Stop);
			break;
		case 3:
			Output.WriteLine("Sending Home...");
			PortFacade.GetConversation(0).Request(Command.Home);
			break;
		case 4:
			Output.WriteLine("Please enter a speed in mm/s ");
			input = Input.ReadLine();
			speed = Convert.ToInt32(Convert.ToDouble(input)/(9.375*(0.49609375/1000)));
			break;
		case 0:
			again = false;
			break;
		default:
			Output.WriteLine("GOODBYE!!!!");
			break;
	}
	Output.WriteLine("");
	Output.WriteLine("");
	Output.WriteLine("");
}
