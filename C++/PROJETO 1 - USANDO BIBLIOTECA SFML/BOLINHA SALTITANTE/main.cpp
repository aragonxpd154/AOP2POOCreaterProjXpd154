#include <SFML/Graphics.hpp>
#include <cmath>

int main()
{
    // Cria a janela
    sf::RenderWindow window(sf::VideoMode(400, 400), "Bolinha saltitante");

    // Cria a bolinha
    sf::CircleShape ball(10.0f);
    ball.setFillColor(sf::Color::Green);
    ball.setPosition(50, 50);

    // Configura a velocidade da bolinha
    sf::Vector2f velocity(2.0f, 2.0f);

    // Inicia o relógio para controlar o frame rate
    sf::Clock clock;

    // Executa o loop principal
    while (window.isOpen())
    {
        // Processa os eventos da janela
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();
        }

        // Atualiza a posição da bolinha
        sf::Time elapsed = clock.restart();
        ball.move(velocity * elapsed.asSeconds());

        // Verifica se a bolinha chegou aos limites da tela
        sf::Vector2f ballPos = ball.getPosition();
        if (ballPos.x + 20 > window.getSize().x || ballPos.x - 10 < 0)
        {
            velocity.x = -velocity.x;
        }
        if (ballPos.y + 20 > window.getSize().y || ballPos.y - 10 < 0)
        {
            velocity.y = -velocity.y;
        }

        // Desenha a bolinha na tela
        window.clear();
        window.draw(ball);
        window.display();
    }

    return 0;
}
