using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Console_Jam
{
    class Animation
    {
        public void Burger()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 8; j > 6; j--)
                {
                    Console.SetCursorPosition(60, j - 1);
                    Console.WriteLine("                                    ");
                    Console.SetCursorPosition(60, j);
                    Console.Write("        ████████████████████            ");
                    Console.SetCursorPosition(60, j + 1);
                    Console.Write("      ██                    ██          ");
                    Console.SetCursorPosition(60, j + 2);
                    Console.Write("    ██    ██          ██      ██        ");
                    Console.SetCursorPosition(60, j + 3);
                    Console.Write("  ██      ████        ████      ██      ");
                    Console.SetCursorPosition(60, j + 4);
                    Console.Write("  ██            ████            ██      ");
                    Console.SetCursorPosition(60, j + 5);
                    Console.Write("  ██                            ██      ");
                    Console.SetCursorPosition(60, j + 6);
                    Console.Write("████████████████████████████████████    ");
                    Console.SetCursorPosition(60, j + 7);
                    Console.Write("██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██    ");
                    Console.SetCursorPosition(60, j + 8);
                    Console.Write("  ████████████████████████████████      ");
                    Console.SetCursorPosition(60, j + 9);
                    Console.Write("██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    ");
                    Console.SetCursorPosition(60, j + 10);
                    Console.Write("  ██░░██░░░░██████░░░░░░██░░░░████      ");
                    Console.SetCursorPosition(60, j + 11);
                    Console.Write("  ████  ████      ██████  ████  ██      ");
                    Console.SetCursorPosition(60, j + 12);
                    Console.Write("  ██                            ██      ");
                    Console.SetCursorPosition(60, j + 13);
                    Console.Write("    ████████████████████████████        ");
                    Console.SetCursorPosition(60, j + 14);
                    Console.WriteLine("                                    ");

                    Thread.Sleep(500);
                }
            }
            
        }

        public void Fry()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 8; j > 6; j--)
                {
                    Console.SetCursorPosition(60, j - 1);
                    Console.WriteLine("                                    ");
                    Console.SetCursorPosition(60, j);
                    Console.Write("       ██      ██  ██               ");
                    Console.SetCursorPosition(60, j + 1);
                    Console.Write("     ██░░██  ██  ██  ██  ██████     ");
                    Console.SetCursorPosition(60, j + 2);
                    Console.Write("   ██  ██  ████  ██    ██    ██     ");
                    Console.SetCursorPosition(60, j + 3);
                    Console.Write(" ██▒▒░░▒▒▒▒  ██    ▒▒░░██░░  ██     ");
                    Console.SetCursorPosition(60, j + 4);
                    Console.Write("   ▒▒██░░██░░░░▒▒░░░░▒▒▒▒░░▒▒       ");
                    Console.SetCursorPosition(60, j + 5);
                    Console.Write("   ░░██▓▓░░▓▓░░░░██  ██░░▓▓██       ");
                    Console.SetCursorPosition(60, j + 6);
                    Console.Write("     ██▒▒▓▓██▓▓▓▓██▓▓████▒▒██       ");
                    Console.SetCursorPosition(60, j + 7);
                    Console.Write("     ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██       ");
                    Console.SetCursorPosition(60, j + 8);
                    Console.Write("     ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██       ");
                    Console.SetCursorPosition(60, j + 9);
                    Console.Write("     ██▒▒██  ▒▒▒▒▒▒▒▒  ██▒▒██        ");
                    Console.SetCursorPosition(60, j + 10);
                    Console.Write("     ██▒▒████▒▒▒▒▒▒▒▒████▒▒██       ");
                    Console.SetCursorPosition(60, j + 11);
                    Console.Write("     ██▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒██       ");
                    Console.SetCursorPosition(60, j + 12);
                    Console.Write("     ██▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒██       ");
                    Console.SetCursorPosition(60, j + 13);
                    Console.Write("     ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██       ");
                    Console.SetCursorPosition(60, j + 14);
                    Console.Write("     ░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓████░░       ");
                    Console.SetCursorPosition(60, j + 15);
                    Console.Write("       ░░░░▒▒░░░░░░░░▒▒░░▒▒         ");
                    Console.SetCursorPosition(60, j + 16);
                    Console.WriteLine("                                   ");

                    Thread.Sleep(500);
                }
            }
        }

        public void IceCream()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 8; j > 6; j--)
                {
                    Console.SetCursorPosition(60, j - 6);
                    Console.WriteLine("                                    ");
                    Console.SetCursorPosition(60, j - 5);
                    Console.Write("        ████████████████        ");
                    Console.SetCursorPosition(60, j - 4);
                    Console.Write("       ██                ██         ");
                    Console.SetCursorPosition(60, j - 3);
                    Console.Write("     ██                    ██       ");
                    Console.SetCursorPosition(60, j - 2);
                    Console.Write("   ██                        ██     ");
                    Console.SetCursorPosition(60, j - 1);
                    Console.Write("   ██                        ██      ");
                    Console.SetCursorPosition(60, j + 0);
                    Console.Write("   ████                    ████     ");
                    Console.SetCursorPosition(60, j + 1);
                    Console.Write("   ██████            ██    ████      ");
                    Console.SetCursorPosition(60, j + 2);
                    Console.Write("   ██  ████          ████    ██      ");
                    Console.SetCursorPosition(60, j + 3);
                    Console.Write("   ██  ██████        ██████  ██      ");
                    Console.SetCursorPosition(60, j + 4);
                    Console.Write(" ██          ██    ██          ██    ");
                    Console.SetCursorPosition(60, j + 5);
                    Console.Write(" ▓▓  ░░░░      ████      ░░░░  ██    ");
                    Console.SetCursorPosition(60, j + 6);
                    Console.Write(" ▓▓  ░░░░      ░░░░      ░░░░  ██    ");
                    Console.SetCursorPosition(60, j + 7);
                    Console.Write("   ████████████████████████████      ");
                    Console.SetCursorPosition(60, j + 8);
                    Console.Write("     ██░░  ░░  ░░  ░░  ░░  ██        ");
                    Console.SetCursorPosition(60, j + 9);
                    Console.Write("     ██  ░░  ░░░░░░  ░░  ░░██        ");
                    Console.SetCursorPosition(60, j + 10);
                    Console.Write("       ▓▓  ░░  ░░  ░░  ░░▓▓         ");
                    Console.SetCursorPosition(60, j + 11);
                    Console.Write("       ██  ░░░░░░░░░░░░░░██         ");
                    Console.SetCursorPosition(60, j + 12);
                    Console.Write("       ░░██░░  ░░  ░░░░▒▒░░         ");
                    Console.SetCursorPosition(60, j + 13);
                    Console.Write("         ██  ░░░░░░  ░░██           ");
                    Console.SetCursorPosition(60, j + 14);
                    Console.Write("           ██  ░░  ░░▓▓             ");
                    Console.SetCursorPosition(60, j + 15);
                    Console.Write("           ██░░░░░░  ▓▓             ");
                    Console.SetCursorPosition(60, j + 16);
                    Console.Write("             ██░░  ▓▓               ");
                    Console.SetCursorPosition(60, j + 17);
                    Console.Write("             ██  ░░██              ");
                    Console.SetCursorPosition(60, j + 18);
                    Console.Write("               ████                 ");
                    Console.SetCursorPosition(60, j + 19);
                    Console.Write("               ░░░░                ");


                    Thread.Sleep(500);
                }
            }

            Console.Clear();
        }


        public void Pasta()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 8; j > 6; j--)
                {
                    Console.SetCursorPosition(60, j - 6);
                    Console.WriteLine("                                               ");
                    Console.SetCursorPosition(60, j - 5);
                    Console.Write("                                          ██▓▓    ");
                    Console.SetCursorPosition(60, j - 4);
                    Console.Write("                                        ██▓▓██    ");
                    Console.SetCursorPosition(60, j - 3);
                    Console.Write("                                      ██▓▓██▓▓     ");
                    Console.SetCursorPosition(60, j - 2);
                    Console.Write("                                    ▓▓▓▓██▓▓██   ");
                    Console.SetCursorPosition(60, j - 1);
                    Console.Write("                                  ██▓▓██▓▓██    ");
                    Console.SetCursorPosition(60, j + 0);
                    Console.Write("                                ██▓▓██▓▓██      ");
                    Console.SetCursorPosition(60, j + 1);
                    Console.Write("                              ██▓▓██▓▓██        ");
                    Console.SetCursorPosition(60, j + 2);
                    Console.Write("              ████████████████████▓▓▓▓           ");
                    Console.SetCursorPosition(60, j + 3);
                    Console.Write("            ██  ██  ██  ██  ██  ████            ");
                    Console.SetCursorPosition(60, j + 4);
                    Console.Write("          ▓▓  ▓▓  ▓▓  ▒▒  ▓▓  ▓▓  ██             ");
                    Console.SetCursorPosition(60, j + 5);
                    Console.Write("        ▓▓  ██  ██  ██  ██  ██  ██  ▓▓           ");
                    Console.SetCursorPosition(60, j + 6);
                    Console.Write("      ██  ██  ██  ██  ▓▓  ██  ██  ██  ██         ");
                    Console.SetCursorPosition(60, j + 7);
                    Console.Write("    ████████▓▓██▓▓██▓▓██▓▓██▓▓██▓▓████████        ");
                    Console.SetCursorPosition(60, j + 8);
                    Console.Write("    ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██       ");
                    Console.SetCursorPosition(60, j + 9);
                    Console.Write("    ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██      ");
                    Console.SetCursorPosition(60, j + 10);
                    Console.Write("    ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██      ");
                    Console.SetCursorPosition(60, j + 11);
                    Console.Write("    ██░░░░░░██    ░░░░░░░░░░▓▓    ░░░░░░██       ");
                    Console.SetCursorPosition(60, j + 12);
                    Console.Write("      ██░░░░████  ░░░░░░░░░░████  ░░░░██         ");
                    Console.SetCursorPosition(60, j + 13);
                    Console.Write("      ██░░░░████▒▒░░░░░░░░░░████▒▒░░░░██        ");
                    Console.SetCursorPosition(60, j + 14);
                    Console.Write("        ▓▓░░░░░░░░░░▓▓░░▓▓░░░░░░░░░░▒▒░░        ");
                    Console.SetCursorPosition(60, j + 15);
                    Console.Write("          ██▒▒▒▒░░░░░░▓▓░░░░░░▒▒▒▒██            ");
                    Console.SetCursorPosition(60, j + 16);
                    Console.Write("            ██░░░░░░░░░░░░░░░░░░██                ");
                    Console.SetCursorPosition(60, j + 17);
                    Console.Write("              ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓               ");
                    Console.SetCursorPosition(60, j + 18);
                    Console.Write("              ░░░░░░░░░░░░░░░░░░               ");
                    Console.SetCursorPosition(60, j + 19);
                    Console.Write("                                               ");


                    Thread.Sleep(500);
                }
            }

            Console.Clear();
        }

        public void Pizza()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 8; j > 6; j--)
                {
                    Console.SetCursorPosition(60, j - 6);
                    Console.WriteLine("                                               ");
                    Console.SetCursorPosition(60, j - 5);
                    Console.Write("                        ████                       ");
                    Console.SetCursorPosition(60, j - 4);
                    Console.Write("                      ██░░░░██                    ");
                    Console.SetCursorPosition(60, j - 3);
                    Console.Write("                    ██░░▒▒██████                ");
                    Console.SetCursorPosition(60, j - 2);
                    Console.Write("                  ██░░░░██▒▒▓▓▓▓██               ");
                    Console.SetCursorPosition(60, j - 1);
                    Console.Write("                  ██░░██▓▓▓▓▓▓▓▓▒▒██             ");
                    Console.SetCursorPosition(60, j + 0);
                    Console.Write("                ██▒▒░░██▓▓▓▓▓▓▒▒▓▓██             ");
                    Console.SetCursorPosition(60, j + 1);
                    Console.Write("                ██░░░░██▓▓▒▒▓▓▓▓▓▓██             ");
                    Console.SetCursorPosition(60, j + 2);
                    Console.Write("              ██░░░░░░░░██▓▓▓▓▒▒██░░██           ");
                    Console.SetCursorPosition(60, j + 3);
                    Console.Write("              ██░░░░▒▒░░░░██████░░░░██         ");
                    Console.SetCursorPosition(60, j + 4);
                    Console.Write("            ██▒▒░░░░░░░░░░░░░░░░░░▒▒░░██       ");
                    Console.SetCursorPosition(60, j + 5);
                    Console.Write("            ██░░  ██░░░░░░▒▒░░░░  ██░░██        ");
                    Console.SetCursorPosition(60, j + 6);
                    Console.Write("          ██░░░░████░░██░░░░██░░████░░░░██     ");
                    Console.SetCursorPosition(60, j + 7);
                    Console.Write("          ██░░▒▒▒▒░░░░░░████░░░░░░▒▒▒▒░░██       ");
                    Console.SetCursorPosition(60, j + 8);
                    Console.Write("        ██▒▒██░░░░░░░░░░░░░░▒▒░░░░░░░░▒▒░░██     ");
                    Console.SetCursorPosition(60, j + 9);
                    Console.Write("        ██▓▓▓▓██░░░░░░▒▒░░░░░░░░▒▒░░░░░░░░██     ");
                    Console.SetCursorPosition(60, j + 10);
                    Console.Write("      ██▓▓▓▓▒▒██░░░░░░░░░░░░░░░░██████░░▒▒░░██    ");
                    Console.SetCursorPosition(60, j + 11);
                    Console.Write("    ████▒▒▓▓▒▒██▒▒░░░░░░▒▒░░░░██▒▒▓▓▓▓██░░░░████    ");
                    Console.SetCursorPosition(60, j + 12);
                    Console.Write("  ██▓▓▒▒██▓▓██░░░░░░░░░░░░░░██▓▓▓▓▓▓▒▒▓▓████▒▒▓▓██    ");
                    Console.SetCursorPosition(60, j + 13);
                    Console.Write("  ██▓▓▒▒▒▒████░░░░▒▒░░▒▒░░░░██▓▓▒▒▓▓▓▓████▒▒▒▒▓▓██     ");
                    Console.SetCursorPosition(60, j + 14);
                    Console.Write("  ██▓▓▒▒▒▒▒▒▒▒████████████████████████▒▒▒▒▒▒▒▒▓▓██     ");
                    Console.SetCursorPosition(60, j + 15);
                    Console.Write("  ██▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██      ");
                    Console.SetCursorPosition(60, j + 16);
                    Console.Write("  ░░██▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓██▒▒    ");
                    Console.SetCursorPosition(60, j + 17);
                    Console.Write("      ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████        ");
                    Console.SetCursorPosition(60, j + 18);
                    Console.Write("          ████████████████████████████████           ");
                    Console.SetCursorPosition(60, j + 19);
                    Console.Write("                                               ");


                    Thread.Sleep(500);
                }
            }

            Console.Clear();
        }
    }
}
