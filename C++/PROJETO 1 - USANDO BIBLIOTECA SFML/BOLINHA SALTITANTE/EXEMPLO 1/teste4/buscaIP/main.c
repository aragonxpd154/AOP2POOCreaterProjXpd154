#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
    // Abre o arquivo CSV para escrita
    FILE *csv = fopen("ips.csv", "w");
    if (csv == NULL) {
        perror("Erro ao abrir o arquivo CSV");
        return 1;
    }

    // Define o intervalo de endere�os IP da rede
    const char *network = "192.168.1";

    // Itera sobre os endere�os IP da rede
    for (int i = 0; i < 255; i++) {
        // Monta o comando ping para o endere�o IP atual
        char command[128];
        sprintf(command, "ping -c 1 %s.%d", network, i);

        // Executa o comando ping
        int result = system(command);

        // Verifica se o comando ping teve sucesso
        if (result == 0) {
            // O endere�o IP est� respondendo ao ping, ent�o salva-o no arquivo CSV
            fprintf(csv, "%s.%d\n", network, i);
        }
    }

    // Fecha o arquivo CSV
    fclose(csv);

    return 0;
}
