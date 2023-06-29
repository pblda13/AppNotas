# Aplicação de Controle de Notas de Aluno

Bem-vindo à aplicação de Controle de Notas de Aluno! Este é um programa Windows Forms que permite inserir notas de um aluno, realizar cálculos e armazenar as informações em um banco de dados. Siga as instruções abaixo para utilizar a aplicação corretamente.

<img width="269" alt="56" src="https://user-images.githubusercontent.com/90057261/191964366-8f35b3a2-2fb9-4c30-a567-82ffb665e5c7.png">

## Requisitos do Sistema

- Computador com sistema operacional Windows.
- Ambiente de desenvolvimento compatível com Windows Forms ( Visual Studio).
- Conhecimentos básicos em programação com C#.
- Banco de dados configurado e acessível (SQL Server, MySQL, SQLite).

## Como Usar

1. Abra o ambiente de desenvolvimento e crie um novo projeto Windows Forms.

2. Na janela de design do formulário principal, adicione os seguintes componentes:
   - Quatro caixas de texto para o usuário inserir as notas do aluno.
   - Rótulos para exibir os resultados das operações.
   - Botões para salvar, recuperar, calcular, limpar e sair.

3. Configure a conexão com o banco de dados, utilizando as bibliotecas adequadas para o banco escolhido. Consulte a documentação do banco de dados para obter informações específicas sobre como estabelecer a conexão.

4. Implemente a lógica de salvar as notas no banco de dados ao clicar no botão "Salvar". Isso envolverá a criação de uma consulta SQL para inserir os dados na tabela correspondente.

5. Implemente a lógica de recuperar as últimas notas salvas do banco de dados ao clicar no botão "Recuperar". Isso envolverá a criação de uma consulta SQL para buscar os dados da tabela e exibi-los nas caixas de texto correspondentes.

6. Implemente a lógica de cálculo das operações mencionadas (maior nota, menor nota, média, soma das notas pares, soma das notas ímpares e quantidade de notas maiores que 7) ao clicar no botão "Calcular". Utilize as notas inseridas nas caixas de texto para realizar os cálculos e exiba os resultados nos rótulos correspondentes.

7. Implemente a lógica de limpar as caixas de texto e rótulos ao clicar no botão "Limpar".

8. Implemente a lógica de sair do programa ao clicar no botão "Sair".

9. Execute a aplicação e teste as funcionalidades, inserindo notas, calculando os resultados, salvando e recuperando os dados do banco de dados.

## Contribuição

Este projeto foi desenvolvido pela Pâmela Borges. Se você identificar algum problema ou desejar contribuir para o projeto, fique à vontade para abrir uma issue ou enviar um pull request no repositório do GitHub.

Esperamos que a aplicação de Controle de Notas de Aluno seja útil para você. Tenha um bom controle de notas!

![Visitantes](https://api.visitorbadge.io/api/visitors?path=https%3A%2F%2Fgithub.com%2Fpblda13%2FAppNotas&label=Visitantes&countColor=%23f47373&style=flat-square)
