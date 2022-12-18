#include <SFML/Graphics.hpp>

int main()
{
    // Cria uma janela com título "Bouncing Ball"
    sf::RenderWindow window(sf::VideoMode(640, 480), "Bouncing Ball");

    // Cria uma bolinha vermelha com raio 10 e posição inicial (320, 240)
    sf::CircleShape ball(10.0f);
    ball.setFillColor(sf::Color::Red);
    ball.setPosition(320.0f, 240.0f);

    // Cria uma velocidade inicial para a bolinha
    sf::Vector2f velocity(100.0f, 100.0f);

    // O relógio é usado para controlar o tempo entre os quadros
    sf::Clock clock;

    // Executa o loop principal do jogo
    while (window.isOpen())
    {
        // Verifica os eventos da janela
        sf::Event event;
        while (window.pollEvent(event))
        {
            // Fecha a janela se o usuário clicar no botão de fechar
            if (event.type == sf::Event::Closed)
            {
                window.close();
            }
        }

        // Atualiza a posição da bolinha com base na velocidade e no tempo transcorrido
        float elapsedTime = clock.restart().asSeconds();
        ball.move(velocity * elapsedTime);

        // Se a bolinha atingir o lado direito ou esquerdo da janela, inverte a velocidade em x
        if (ball.getPosition().x + ball.getRadius() > window.getSize().x || ball.getPosition().x - ball.getRadius() < 0)
        {
            velocity.x = -velocity.x;
        }

        // Se a bolinha atingir o topo ou base da janela, inverte a velocidade em y
        if (ball.getPosition().y + ball.getRadius() > window.getSize().y || ball.getPosition().y - ball.getRadius() < 0)
        {
            velocity.y = -velocity.y;
        }

        // Limpa a tela com uma cor preta
        window.clear(sf::Color::Black);

        // Desenha a bolinha na tela
        window.draw(ball);

        // Exibe o que foi desenhado na janela
        window.display();
    }

    return 0;
}
