#include <iostream>
#include <libssh/libssh.h>

int main(int argc, char* argv[])
{
    // Verifica se foi informado o endere�o do servidor e a porta
    if (argc < 3)
    {
        std::cout << "Uso: teste_ssh endereco_servidor porta" << std::endl;
        return 1;
    }

    // Obt�m o endere�o do servidor e a porta a partir dos argumentos da linha de comando
    const char* host = argv[1];
    int port = std::atoi(argv[2]);

    // Inicializa a biblioteca libssh
    ssh_init();

    // Cria um objeto ssh_session para estabelecer a conex�o
    ssh_session session = ssh_new();
    if (session == nullptr)
    {
        std::cout << "Erro ao criar a sess�o SSH" << std::endl;
        return 1;
    }

    // Define as op��es da sess�o SSH
    ssh_options_set(session, SSH_OPTIONS_HOST, host);
    ssh_options_set(session, SSH_OPTIONS_PORT, &port);

    // Tenta estabelecer a conex�o com o servidor SSH
    int rc = ssh_connect(session);
    if (rc != SSH_OK)
    {
        std::cout << "Erro ao conectar ao servidor SSH: " << ssh_get_error(session) << std::endl;
        ssh_free(session);
        return 1;
    }

    // Verifica a autentica��o do servidor
    rc = ssh_is_server_known(session);
    if (rc != SSH_SERVER_KNOWN_OK)
    {
        std::cout << "Erro na verifica��o da autentica��o do servidor: " << ssh_get_error(session) << std::endl;
        ssh_disconnect(session);
        ssh_free(session);
        return 1;
    }

    std::cout << "Conex�o com o servidor SSH estabelecida com sucesso" << std::endl;

    // Fecha a conex�o e libera a mem�ria alocada para a sess�o SSH
    ssh_disconnect(session);
    ssh_free(session);

    return 0;
}
