#include <stdio.h>
#include <graphics.h>

int main(void)
{
    // Inicializa a janela gr�fica
    int width = 800, height = 600;
    initwindow(width, height);

    // Desenha um ret�ngulo preenchido com a cor vermelha
    setcolor(RED);
    setfillstyle(SOLID_FILL, RED);
    bar(0, 0, width, height);

    // Exibe um texto na tela
    setcolor(WHITE);
    outtextxy(10, 10, "Texto qualquer");

    // Carrega uma imagem na mem�ria
    int image = loadimage("imagem.bmp");

    // Desenha a imagem na tela
    putimage(10, 50, image);

    // Exibe a janela gr�fica
    getch();
    closegraph();

    return 0;
}
