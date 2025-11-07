using System;
					
Console.WriteLine("The Shiba Inus, Pup-Tart, Akira, Poppy, and the honorary Shiba, Remus, have a lot of toys. Here's an inventory of what they have.\n");
Console.ReadLine();						//Press Enter to Continue

string[] shibaToys = {"Tennis Ball", "Stuffed Moose", "Rope", "Bone", "Stuffed Strawberry", "Nylabone", "Stick Chew Toy"};
int shibaInventory = shibaToys.Length;	//Used to track how many toys have been removed
int shibaSelection = 0;
int shibaIndex = 0;

Console.WriteLine("SHIBA TOYS");
Array.Sort(shibaToys);

foreach (var toy in shibaToys)			//Loop to display the current inventory of Shiba toys
	{
		Console.WriteLine($"{shibaIndex}\t{toy}");
		shibaIndex ++;
	}
Console.WriteLine(""); 					//Skip a line
Console.WriteLine($"There are {shibaToys.Length} Shiba toys.\n");

Console.ReadLine();						//Press Enter to Continue
	
Console.WriteLine("Now each silly Shiba will take a toy.\n");
Console.ReadLine();						//Press Enter to Continue

//Select a toy for Pup-Tart
Console.Write($"Pup-Tart: \t(Enter an Index number to select the toy to give to Pup-Tart): ");
shibaSelection = Convert.ToInt32(Console.ReadLine());

//Checks to make sure you selected a toy that hasn't been taken and is within the array scope
while (shibaSelection < 0 || shibaSelection > 7)
	{
	Console.WriteLine("That is outside the scope of the inventory. Try again.");
	shibaSelection = Convert.ToInt32(Console.ReadLine());
	};
while (shibaToys[shibaSelection] == null)
{
	Console.WriteLine("There's no toy there. Try again.");
	shibaSelection = Convert.ToInt32(Console.ReadLine());
}

switch (shibaSelection)
{
case 0:	
	Console.WriteLine(shibaToys[shibaSelection]);
	Console.WriteLine("Pup-Tart likes the bone; every now and then, he goes for it. But he has other preferences.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 1:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("He would take the Nylabone- but Poppy steals it from him a lot. He lets her.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 2:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Not his favorite. It's a little big for him.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 3:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("He loves the stick chew toy- unfortunately for him, that's Poppy's favorite. She WILL steal it, and he'll absolutely let her.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 4:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("This one used to be our daughter's baby toy- and it's still in decent shape. He gets it out every now and then, and it was one of his first toys.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 5:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("This was also one of our daughter's baby toys, and it's his absolute favorite. He loses his mind any time he sees a new stuffed strawberry, and he's very protective of it.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 6:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("He loves tennis balls. Sometimes we let him rummage through the tennis balls to pick one he likes, and he'll bounce around the house/yard with it. It's really cute.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
default:
	Console.WriteLine("You broke it.");	
	break;
}
Console.WriteLine(""); Console.ReadLine();

//Select a toy for Poppy
Console.Write($"Poppy: \t(Enter an Index number to select the toy to give to Poppy): ");
shibaSelection = Convert.ToInt32(Console.ReadLine());

//Checks to make sure you selected a toy that hasn't been taken and is within the array scope
while (shibaSelection < 0 || shibaSelection > 7)
	{
	Console.WriteLine("That is outside the scope of the inventory. Try again.");
	shibaSelection = Convert.ToInt32(Console.ReadLine());
	};
while (shibaToys[shibaSelection] == null)
{
	Console.WriteLine("There's no toy there. Try again.");
	shibaSelection = Convert.ToInt32(Console.ReadLine());
}

switch (shibaSelection)
{
case 0:	
	Console.WriteLine(shibaToys[shibaSelection]);
	Console.WriteLine("Much like her dad, she likes the bone a lot She's okay with taking turns with this one.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 1:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("This is one of Poppy's favorites. Sweet as she is, she'll annoy the other dogs to get it.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 2:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Yeah she's gonna ignore that. Much too big for her.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 3:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Probably her absolute favorite toy of all time. She will incessantly annoy any dog that has it until she gets it- even if it takes her 20 minutes.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 4:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Poppy is picky. She doesn't care about the moose.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 5:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("She would never touch the strawberry. She seems to understand it's important to Pup-Tart- which is cute. But she'll chew on it a little if he's not around.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 6:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Much like her dad, she will chase after a ball if you throw it. But she'll get bored quicker.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
default:
	Console.WriteLine("You broke it.");	
	break;
}
Console.WriteLine(""); Console.ReadLine();

//Select a toy for Akira
Console.Write($"Akira: \t(Enter an Index number to select the toy to give to Akira): ");
shibaSelection = Convert.ToInt32(Console.ReadLine());

//Checks to make sure you selected a toy that hasn't been taken and is within the array scope
while (shibaSelection < 0 || shibaSelection > 7)
	{
	Console.WriteLine("That is outside the scope of the inventory. Try again.");
	shibaSelection = Convert.ToInt32(Console.ReadLine());
	};
while (shibaToys[shibaSelection] == null)
{
	Console.WriteLine("There's no toy there. Try again.");
	shibaSelection = Convert.ToInt32(Console.ReadLine());
}

switch (shibaSelection)
{
case 0:	
	Console.WriteLine(shibaToys[shibaSelection]);
	Console.WriteLine("This is one of Akira's preferred toys. She likes to chew more than she does play.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 1:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Akira likes Nylabones a lot, this is a go-to for her.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 2:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("She will absolutely look at you like an idiot for giving her this.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 3:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("She will chew on it if Poppy isn't around- so she has to hide if she doesn't want it stolen.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 4:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Akira is a diva with standards, and a moose baby toy is beneath her.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 5:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("She has never shown much interest in the strawberry. Probably knows it's important to Pup-Tart.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 6:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Akira doesn't understand the concept of chasing a ball.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
default:
	Console.WriteLine("You broke it.");	
	break;
}
Console.WriteLine(""); Console.ReadLine();

//Select a toy for Remus
Console.Write($"Remus: \t(Enter an Index number to select the toy to give to the honorary Shiba, Remus): ");
shibaSelection = Convert.ToInt32(Console.ReadLine());

//Checks to make sure you selected a toy that hasn't been taken and is within the array scope
while (shibaSelection < 0 || shibaSelection > 7)
	{
	Console.WriteLine("That is outside the scope of the inventory. Try again.");
	shibaSelection = Convert.ToInt32(Console.ReadLine());
	};
while (shibaToys[shibaSelection] == null)
{
	Console.WriteLine("There's no toy there. Try again.");
	shibaSelection = Convert.ToInt32(Console.ReadLine());
}

switch (shibaSelection)
{
case 0:	
	Console.WriteLine(shibaToys[shibaSelection]);
	Console.WriteLine("Like all the dogs, Remus likes the bone. He's had this thing for many many years.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 1:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Remus is a simple lad- give him a bone, he will munch.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 2:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Remus might actually play tug-of-war with you; it's a larger rope meant for a dog his size");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 3:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Remus doesn't really bother with this too much.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 4:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Remus will probably take it from you, then sit it down. He's not that bright sometimes.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 5:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Remus won't touch the strawberry. He knows that's not his.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
case 6:	
	Console.WriteLine(shibaToys[shibaSelection]);
		Console.WriteLine("Excellent at catching balls mid-air. Probably his favorite toy.");
		Array.Clear(shibaToys,shibaSelection,1);				//Remove the toy from inventory
		shibaInventory --;
	break;
default:
	Console.WriteLine("You broke it.");	
	break;
}
Console.ReadLine();						//Press Enter to Continue

Console.WriteLine("Let's see what toys are left:");
Console.ReadLine();						//Press Enter to Continue

//Consolidate the Toys by copying the toys into a new array, using shivaInventory variable to ignore nulls and only copy the remaining toys
string[] remainingShibaToys = new string[7];
Array.Sort(shibaToys);
Array.Copy(shibaToys,shibaInventory+1,remainingShibaToys,0,shibaInventory);
Array.Resize(ref remainingShibaToys,remainingShibaToys.Length - (1+shibaInventory));

foreach (var toy in remainingShibaToys)	//Final Inventory Loop
	{
		Console.WriteLine($"{toy}");
	}
Console.WriteLine($"There are {remainingShibaToys.Length} Shiba toys.\n");