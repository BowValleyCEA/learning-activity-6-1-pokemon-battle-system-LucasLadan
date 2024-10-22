using game1401_la_starter;

Pokemon fire = new Pokemon(70, 10, "Castform", Type.fire, Type.water);
Pokemon water = new Pokemon(55,16,"Gorebyss",Type.water, Type.grass);
Pokemon grass = new Pokemon(75, 8, "Jumpluff", Type.grass, Type.fire);
Pokemon normal = new Pokemon(60, 14, "Teddiursa",Type.normal,Type.none);
game();
int inputInt(int max)
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
    switch (inputInt(4))
    {
        case 1:
            player1 = fire;
            break;
        case 2:
            player1 = water;
            break;
        case 3:
            player1 = grass;
            break;
        default:
            player1 = normal;
            break;
    }

    Console.WriteLine("Player 2 pick your pokemon\n1: Castform sunny form\n2: Gorebyss\n3: Jumpluff\n4: Teddirusa");
    Player player2;
    switch (inputInt(4))
    {
        case 1:
            player2 = new Player(fire);
            break;
        case 2:
            player2 = new Player(water);
            break;
        case 3:
            player2 = new Player(grass);
            break;
        default:
            player2 = new Player(normal);
            break;
    }


    bool noFaints = true;

    do
    {

        player1.GetPokemon().printHealth();
        player2.GetPokemon().printHealth();

        Console.WriteLine("Player 1 what are you going to do\n1: Attack\n2: Use an item (You currently have "
            +player1.getItemCount()+" items)\n3: Run");

        switch (inputInt(3))
        {
            case 1:
                noFaints = player2.takeDamage(player1.GetPokemon());
                break;
            case 2:
                player1.healPokemon();
                break;
            default:
                Console.WriteLine("You can't run from a trainer battle!");
                break;
        }

        if (noFaints)
        {
            player1.GetPokemon().printHealth();
            player2.GetPokemon().printHealth();
            Console.WriteLine("Player 2 what are you going to do\n1: Attack\n2: Use an item (You currently have "
            + player1.getItemCount() + " items)\n3: Run");

            switch (inputInt(3))
            {
                case 1:
                    noFaints = player1.takeDamage(player2.GetPokemon());
                    break;
                case 2:
                    player2.healPokemon();
                    break;
                default:
                    Console.WriteLine("You can't run from a trainer battle!");
                    break;
            }
        }
    } while (noFaints);
}

enum Type
{
    normal,
    fire,
    grass,
    water,
    none
}