//BATALHA NAVAL //JxA 
int tamanhoTabuleiro = 5;
char[,] tabuleiroUsuario = new char[tamanhoTabuleiro, tamanhoTabuleiro];
char[,] tabuleiroMaquina = new char[tamanhoTabuleiro, tamanhoTabuleiro];
char[,] tabuleiroMaquinaOculto = new char[tamanhoTabuleiro, tamanhoTabuleiro];


void ComecarTabuleiro()
{
    for (int i = 0; i < tamanhoTabuleiro; i++)
    {
        for (int j = 0; j < tamanhoTabuleiro; j++)
        {
            tabuleiroUsuario[i, j] = '~';
            tabuleiroMaquina[i, j] = '~';
            tabuleiroMaquinaOculto[i, j] = '~';
        }
    }
}
void ExibirTabuleiroUsuario()
{
    Console.WriteLine();
    Console.WriteLine("Campo Aliado:");
    Console.Write("  ");
    for (int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
    {
        Console.Write(coluna + " ");
    }
    Console.WriteLine();

    for (int linha = 0; linha < tamanhoTabuleiro; linha++)
    {
        Console.Write(linha + " ");
        for (int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
        {
            Console.Write(tabuleiroUsuario[linha, coluna] + " ");
        }
        Console.WriteLine();
    }
}

void ExibirTabuleiroMaquina()
{
    Console.WriteLine();
    Console.WriteLine("Campo Inimigo:");
    Console.Write("  ");
    for (int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
    {
        Console.Write(coluna + " ");
    }
    Console.WriteLine();

    for (int linha = 0; linha < tamanhoTabuleiro; linha++)
    {
        Console.Write(linha + " ");
        for (int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
        {
            Console.Write(tabuleiroMaquina[linha, coluna] + " ");
        }
        Console.WriteLine();
    }
}

void ExibirTabuleiroOculto()
{
    Console.WriteLine();
    Console.WriteLine("//TABULEIRO OCULTO//");
    Console.Write("  ");
    for (int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
    {
        Console.Write(coluna + " ");
    }
    Console.WriteLine();
    for (int linha = 0; linha < tamanhoTabuleiro; linha++)
    {
        Console.Write(linha + " ");
        for (int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
        {
            Console.Write(tabuleiroMaquinaOculto[linha, coluna] + " ");
        }
        Console.WriteLine();
    }
}

void ColocarNaviosNoTabuleiroDoUsuario(char[,] tabuleiro)
{
    Console.WriteLine("Posicionamento dos Navios => 1x Cruzador (3 Casas), 1x Destróier (2 Casas) e 2x Patrulha (1 Casa)");

    int naviosColocados = 0;
    while (naviosColocados < 4)
    {
        
        Console.Write("  ");
        for (int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
        {
            Console.Write(coluna + " ");
        }
        Console.WriteLine();
        for (int linha = 0; linha < tamanhoTabuleiro; linha++)
        {
            Console.Write(linha + " ");
            for (int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
            {
                Console.Write(tabuleiro[linha, coluna] + " ");
            }
            Console.WriteLine();
        }

        if (naviosColocados == 0)
        {
            Console.WriteLine("Primeiro, coloque seu Cruzador (3 casas):");
            Console.Write("Linha inicial: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Coluna inicial: ");
            int coluna = int.Parse(Console.ReadLine());
            Console.WriteLine("Orientação (H ou V):");
            char orientacao = char.Parse(Console.ReadLine());
 
            if ((orientacao == 'H' || orientacao == 'h') && linha >= 0 && linha < tamanhoTabuleiro && coluna >= 0 && coluna + 2 < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~' && tabuleiro[linha, coluna + 1] == '~' && tabuleiro[linha, coluna + 2] == '~')
            {
                tabuleiro[linha, coluna] = 'C';
                tabuleiro[linha, coluna + 1] = 'C';
                tabuleiro[linha, coluna + 2] = 'C';
                naviosColocados++;
            }
            else if ((orientacao == 'V' || orientacao == 'v') && linha >= 0 && linha + 2 < tamanhoTabuleiro && coluna >= 0 && coluna < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~' && tabuleiro[linha + 1, coluna] == '~' && tabuleiro[linha + 2, coluna] == '~')
            {
                tabuleiro[linha, coluna] = 'C';
                tabuleiro[linha + 1, coluna] = 'C';
                tabuleiro[linha + 2, coluna] = 'C';
                naviosColocados++;
            }
            else
            {
                Console.WriteLine("Posição inválida ou já ocupada. Tente novamente.");
            }
        }
        else if (naviosColocados == 1)
        {
            Console.WriteLine("Agora, coloque seu Destróier (2 casas):");
            Console.Write("Linha inicial: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Coluna inicial: ");
            int coluna = int.Parse(Console.ReadLine());
            Console.WriteLine("Orientação (H ou V):");
            char orientacao = char.Parse(Console.ReadLine());
 
            if ((orientacao == 'H' || orientacao == 'h') && linha >= 0 && linha < tamanhoTabuleiro && coluna >= 0 && coluna + 1 < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~' && tabuleiro[linha, coluna + 1] == '~')
            {
                tabuleiro[linha, coluna] = 'D';
                tabuleiro[linha, coluna + 1] = 'D';
                naviosColocados++;
            }
            else if ((orientacao == 'V' || orientacao == 'v') && linha >= 0 && linha + 1 < tamanhoTabuleiro && coluna >= 0 && coluna < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~' && tabuleiro[linha + 1, coluna] == '~')
            {
                tabuleiro[linha, coluna] = 'D';
                tabuleiro[linha + 1, coluna] = 'D';
                naviosColocados++;
            }
            else
            {
                Console.WriteLine("Posição inválida ou já ocupada. Tente novamente.");
            }
        }
        else
        {
            Console.WriteLine($"Agora, coloque sua Patrulha {naviosColocados - 1} (1 casa):");
            Console.Write("Linha: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Coluna: ");
            int coluna = int.Parse(Console.ReadLine());
            if (linha >= 0 && linha < tamanhoTabuleiro && coluna >= 0 && coluna < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~')
            {
                if (naviosColocados == 2)
                {
                    tabuleiro[linha, coluna] = 'P';
                }
                else
                {
                    tabuleiro[linha, coluna] = 'Q';
                }
                naviosColocados++;
            }
            else
            {
                Console.WriteLine("Posição inválida ou já ocupada. Tente novamente.");
            }
        }
    }
}

void ColocarNaviosNoTabuleiroDaMaquina(char[,] tabuleiro)
{
    int naviosColocados = 0;
    while (naviosColocados < 4)
    {
        int linha = Random.Shared.Next(tamanhoTabuleiro);
        int coluna = Random.Shared.Next(tamanhoTabuleiro);
        int orientacao = Random.Shared.Next(2);

        if (naviosColocados == 0)
        {
            if (orientacao == 0 && coluna + 2 < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~' && tabuleiro[linha, coluna + 1] == '~' && tabuleiro[linha, coluna + 2] == '~')
            {
                tabuleiro[linha, coluna] = 'C';
                tabuleiro[linha, coluna + 1] = 'C';
                tabuleiro[linha, coluna + 2] = 'C';
                naviosColocados++;
            }
            else if (orientacao == 1 && linha + 2 < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~' && tabuleiro[linha + 1, coluna] == '~' && tabuleiro[linha + 2, coluna] == '~')
            {
                tabuleiro[linha, coluna] = 'C';
                tabuleiro[linha + 1, coluna] = 'C';
                tabuleiro[linha + 2, coluna] = 'C';
                naviosColocados++;
            }
        }
        else if (naviosColocados == 1)
        {
            if (orientacao == 0 && coluna + 1 < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~' && tabuleiro[linha, coluna + 1] == '~')
            {
                tabuleiro[linha, coluna] = 'D';
                tabuleiro[linha, coluna + 1] = 'D';
                naviosColocados++;
            }
            else if (orientacao == 1 && linha + 1 < tamanhoTabuleiro && tabuleiro[linha, coluna] == '~' && tabuleiro[linha + 1, coluna] == '~')
            {
                tabuleiro[linha, coluna] = 'D';
                tabuleiro[linha + 1, coluna] = 'D';
                naviosColocados++;
            }
        }
        else if (tabuleiro[linha, coluna] == '~')
        {
            if (naviosColocados == 2)
            {
                tabuleiro[linha, coluna] = 'P';
            }
            else
            {
                tabuleiro[linha, coluna] = 'Q';
            }
            naviosColocados++;
        }
    }
}

ComecarTabuleiro();
ColocarNaviosNoTabuleiroDoUsuario(tabuleiroUsuario);
ColocarNaviosNoTabuleiroDaMaquina(tabuleiroMaquinaOculto);

int acertosNoUsuario = 0;
int acertosNaMaquina = 0;

while (acertosNoUsuario < 7 && acertosNaMaquina < 7)
{
    
    ExibirTabuleiroUsuario();
    ExibirTabuleiroMaquina();
    Console.WriteLine("Sua vez de atacar.");
    Console.Write("Linha do ataque: ");
    int linha = int.Parse(Console.ReadLine());
    Console.Write("Coluna do ataque: ");
    int coluna = int.Parse(Console.ReadLine());

    if (linha >= 0 && linha < tamanhoTabuleiro && coluna >= 0 && coluna < tamanhoTabuleiro && tabuleiroMaquina[linha, coluna] == '~')
    {
        Console.WriteLine($"Você atacou a posição {linha}, {coluna}.");
        if (tabuleiroMaquinaOculto[linha, coluna] != '~')
        {
            tabuleiroMaquina[linha, coluna] = 'X';
            acertosNaMaquina++;
            Console.WriteLine("Acertou um navio!");
        }
        else
        {
            tabuleiroMaquina[linha, coluna] = 'O';
            Console.WriteLine("Errou!");
        }
        ExibirTabuleiroMaquina();
    }
    else
    {
        Console.WriteLine("Posição inválida ou já atacada. Tente novamente.");
        continue;
    }

    if (acertosNaMaquina == 7)
    {
        Console.WriteLine("Você venceu!");
        break;
    }

    int linhaMaquina;
    int colunaMaquina;
    do
    {
        linhaMaquina = Random.Shared.Next(tamanhoTabuleiro);
        colunaMaquina = Random.Shared.Next(tamanhoTabuleiro);
    }
    while (tabuleiroUsuario[linhaMaquina, colunaMaquina] == 'X' || tabuleiroUsuario[linhaMaquina, colunaMaquina] == 'O');

    Console.WriteLine($"A máquina atacou a posição {linhaMaquina}, {colunaMaquina}.");
    if (tabuleiroUsuario[linhaMaquina, colunaMaquina] == 'C' || tabuleiroUsuario[linhaMaquina, colunaMaquina] == 'D' || tabuleiroUsuario[linhaMaquina, colunaMaquina] == 'P' || tabuleiroUsuario[linhaMaquina, colunaMaquina] == 'Q')
    {
        tabuleiroUsuario[linhaMaquina, colunaMaquina] = 'X';
        acertosNoUsuario++;
        Console.WriteLine("A máquina acertou um navio!");
    }
    else
    {
        tabuleiroUsuario[linhaMaquina, colunaMaquina] = 'O';
        Console.WriteLine("A máquina errou.");
    }
    ExibirTabuleiroUsuario();
}

if (acertosNoUsuario == 7)
{
    Console.WriteLine("A máquina venceu!");
}


ExibirTabuleiroUsuario();
ExibirTabuleiroMaquina();
ExibirTabuleiroOculto();