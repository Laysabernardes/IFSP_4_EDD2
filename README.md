# ProjetoBilheteria

Este projeto implementa um sistema de controle de ocupa��o para um teatro com 600 lugares, dispostos em 15 fileiras com 40 poltronas cada. O sistema permite reservar poltronas, visualizar um mapa de ocupa��o e calcular o faturamento total com base nas reservas realizadas.

## Funcionalidades

1. **Reservar Poltrona**:
   - O sistema solicita a fileira e o n�mero da poltrona.
   - Verifica se o lugar est� vago e, em caso afirmativo, realiza a reserva e informa o usu�rio.
   - Caso o lugar j� esteja ocupado, uma mensagem de alerta � exibida.
   - As reservas s�o salvas em um arquivo de texto (`estadoPoltronas.txt`) para persist�ncia dos dados.

2. **Mapa de Ocupa��o**:
   - Exibe na tela um mapa com a ocupa��o do teatro, onde:
     - `.` representa lugar vago.
     - `#` representa lugar ocupado.

3. **Faturamento**:
   - Apresenta a quantidade de lugares ocupados e o valor total da bilheteria, com pre�os diferenciados por fileira:
     - Fileiras 1 a 5: R$ 50,00
     - Fileiras 6 a 10: R$ 30,00
     - Fileiras 11 a 15: R$ 15,00

4. **Salvar Reservas**:
   - Todas as reservas realizadas s�o salvas em um arquivo de texto (`estadoPoltronas.txt`), permitindo que o sistema recupere as ocupa��es salvas ao ser reaberto.

#Programa Funcionando:

![Gif do projeto](./bilheteria.gif)