
string matrice_txt = @"
▒  ▒ ▒ ▒▒                                                        ▒                           ▒
▒ ▒▒ ▒ ▒▒ ▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒ ▒ ▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒
▒ ▒▒ ▒ ▒▒ ▒ ▒                                                ▒ ▒ ▒ ▒                      ▒▒ ▒
▒ ▒▒ ▒ ▒▒ ▒ ▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒ ▒ ▒ ▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒ ▒
▒ ▒▒ ▒ ▒▒ ▒ ▒                   ▒▒ ▒A                        ▒ ▒ ▒ ▒                    ▒ ▒▒ ▒
▒ ▒▒ ▒ ▒▒ ▒ ▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒ ▒ ▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒ ▒
▒ ▒▒ ▒ ▒▒ ▒                                                  ▒ ▒ ▒                        ▒▒ ▒
▒ ▒▒ ▒ ▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒
▒ ▒▒ ▒ ▒▒ ▒▒▒                      ▒▒                                                        ▒
▒ ▒▒      ▒▒▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒▒▒ ▒▒▒▒ ▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒ ▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒ ▒▒ ▒▒ ▒▒                     ▒▒ ▒                            ▒
▒                                  ▒▒ ▒▒ ▒▒▒▒▒▒▒▒ ▒▒▒▒ ▒▒▒▒▒ ▒▒ ▒ ▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒
▒ ▒ ▒ ▒ ▒▒▒ ▒▒▒▒▒ ▒▒▒ ▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒ ▒▒                   ▒ ▒▒ ▒ ▒  ▒  ▒  ▒  ▒  ▒  ▒  ▒ ▒ ▒ ▒
▒     ▒ ▒▒▒ ▒   ▒ ▒ ▒ ▒ ▒ ▒▒          ▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒ ▒▒ ▒ ▒                        ▒ ▒
▒ ▒ ▒ ▒ ▒▒▒ ▒ ▒ ▒▒▒     ▒ ▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒     ▒▒ ▒▒▒▒▒ ▒▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒▒ ▒ ▒
▒ ▒ ▒ ▒ ▒▒▒   ▒           ▒▒                    ▒ ▒               ▒                        ▒ ▒
▒▒▒▒▒▒▒ ▒▒▒ ▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒D          ▒                                     ▒▒▒                                        ▒
";

Console.OutputEncoding = System.Text.Encoding.UTF8;

Lab.load(matrice_txt);

int [] depart = Lab.findStart();

Lab.solve(depart[0], depart[1]);


















public class Lab 
{
    const char DEPART = 'D';
    const char ARRIVEE = 'A';
    const char VISITE = '\u2022';
    const char SORTIE = '\u25ca';
    const char MAUVAIS = '\u2591';
    const char BRIQUE = '\u2592';
    const char HORIZONTAL = '\u2501';
    const char VERTICAL = '\u2503';
    const char COIN_HAUT_GAUCHE = '\u250f';
    const char COIN_HAUT_DROIT = '\u2513';
    const char COIN_BAS_GAUCHE = '\u2517';
    const char COIN_BAS_DROIT = '\u251b';

    static char [,] matrice = new char[1,1];
    static int lig = 0;
    static int col = 0;

    static int delay = 10;

    public static void load(string tpl) {

        // On découpe le modèle de labyrinthe en tableau de string
        string[] tmp_list = tpl.Split("\n");
        lig = tmp_list.Length;

        // On cherche la plus grande dimension du labyrinthe
        foreach (string tmp_string in tmp_list)
        {
            if (tmp_string.Length>col)
                col = tmp_string.Length;
        }

        matrice = new char[tmp_list.Length, col];

        for (int x = 0; x < lig; x++)
        {
            for (int y = 0; y < col; y++)
            {
                matrice[x,y] = BRIQUE;
            }
        }

        for (int x = 0; x < lig; x++)
        {
            for (int y = 0; y < tmp_list[x].Length; y++)
            {
                matrice[x,y] = tmp_list[x][y];
                // matrice[x,y] = matrice[x,y]=='x'?' ':matrice[x,y];
            }
        }
    }

    public static int[] findStart() {

        for (int x = 0; x < lig; x++)
        {
            for (int y = 0; y < col; y++)
            {
                if (matrice[x,y]=='D') {
                    int [] tmp = {x, y};
                    return tmp;
                }
            }
        }

        throw new Exception("Le départ n'est pas présent dans la matrice...");
    }

    public static void print() {
        // return;
        // Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write(COIN_HAUT_GAUCHE);
        for (int y = 0; y < col; y++)
        {
            Console.Write(HORIZONTAL);
        }
        Console.WriteLine(COIN_HAUT_DROIT);
        for (int x = 0; x < lig; x++)
        {
            Console.Write(VERTICAL);
            for (int y = 0; y < col; y++)
            {
                Console.Write(matrice[x,y]);
            }
            Console.WriteLine(VERTICAL);
        }

        Console.Write(COIN_BAS_GAUCHE);
        for (int y = 0; y < col; y++)
        {
            Console.Write(HORIZONTAL);
        }
        Console.WriteLine(COIN_BAS_DROIT);
        
        Thread.Sleep(delay);
    }

    public static bool enDehors(int l, int c) {

        if (l<0 || l>=lig) return false;
        if (c<0 || c>=col) return false;
        return true;
    }

    public static void solve(int l, int c) {
        
        int[][] directions = {new int[2] {0, 1}, new int[2] {1, 0}, new int[2] {0, -1}, new int[2] {-1, 0}};
        
        if (matrice[l, c] == 'A') {
            matrice[l,c] = SORTIE;
            print();
        }
        else {

            matrice[l, c] = VISITE;
            print();

            int ln = 0;
            int cn = 0;
            int[][] shuffle =  directions.OrderBy(n => Guid.NewGuid()).ToArray();
            foreach (int[] direction in shuffle)
            {
                ln = l + direction[0];
                cn = c + direction[1];

                if (!enDehors(ln, cn)) 
                    continue;

                if(matrice[ln, cn] == VISITE || matrice[ln, cn] == MAUVAIS || matrice[ln, cn] == BRIQUE)
                    continue;

                solve(ln, cn);

                if (matrice[ln, cn] == SORTIE) {
                    break;
                }

            }

            if (matrice[ln, cn] == SORTIE) {
                matrice[l,c] = SORTIE;
            }
            else {
                matrice[l,c] = MAUVAIS;
            }
            print();
        }
    }
}


