using game1401_la_starter;

FireType fire = new FireType(70, 10, "Castform", Type.fire, Type.grass);
WaterType water = new WaterType(55,16,"Gorebyss",Type.water, Type.fire);
Pokemon grass = new Pokemon(75, 8, "Jumpluff", Type.grass, Type.water);
Pokemon normal = new Pokemon(60, 14, "Teddiursa",Type.normal,Type.none);
game();
int inputInt(int max)//Asking the user to input a number between 1 and the maximum set
{
    int input = 0;

    do
    {
        Console.WriteLine("Please input a number between 1 and " + max);
    } while (!(int.TryParse(Console.ReadLine(), out input)) || (input < 1 || input > max));

    return input;
}

void game()
{
    Console.WriteLine("Player 1 pick your pokemon\n1: Castform sunny form\n2: Gorebyss\n3: Jumpluff\n4: Teddirusa");
    Pokemon player1;
    switch (inputInt(4))//Asking player 1 which pokemon their gonna use
    {
        case 1://Castform / Fire
            player1 = fire;
            break;
        case 2:// Gorebyss / Water
            player1 = water;
            break;
        case 3://Jumpluff / Grass
            player1 = grass;
            break;
        default://Teddiursa / Normal
            player1 = normal;
            break;
    }

    Console.WriteLine("Player 2 pick your pokemon\n1: Castform sunny form\n2: Gorebyss\n3: Jumpluff\n4: Teddirusa");
    Pokemon player2;
    switch (inputInt(4))//Asking player 2 which pokemon their gonna use
    {
        case 1:
            player2 = fire;
            break;
        case 2:
            player2 = water;
            break;
        case 3:
            player2 = grass;
            break;
        default:
            player2 = normal;
            break;
    }


    bool noFaints = true;

    do
    {

        if (player1.isBurned())//Checking if the player is burned
        {
            player1.takeDamage(4);//Taking damage if their burned
        }

        if (player2.isBurned())
        {
            player2.takeDamage(4);
        }

        player1.printHealth();
        player2.printHealth();

        Console.WriteLine("Player 1 what are you going to do\n1: Attack\n2: Heal\n3: Run");

        switch (inputInt(3))//Asking player 1 what pokemon their gonna use
        {
            case 1://Attacking
                noFaints = player1.attack(player2);
                break;
            case 2://Healing
                player1.heal(20);
                break;
            default://"Running"
                Console.WriteLine("You can't take the cowards way out");
                break;
        }

        if (noFaints)//Making sure that player 2's pokemon didnt faint
        {
            player1.printHealth();
            player2.printHealth();

            Console.WriteLine("Player 2 what are you going to do\n1: Attack\n2: Heal\n3: Run");
            switch (inputInt(3))
            {
                case 1:
                    noFaints = player2.attack(player1);
                    break;
                case 2:
                    player2.heal(20);
                    break;
                default:
                    Console.WriteLine("You can't take the cowards way out");
                    break;
            }
        }
    } while (noFaints);//Repeating until a pokemon faints
}

enum Type
{
    normal,
    fire,
    grass,
    water,
    none
}