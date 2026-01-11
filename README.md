📚 Sistema de Gestão de Biblioteca (POO)
Este é um projeto desenvolvido em C# para consolidar conhecimentos em Programação Orientada a Objetos (POO). O sistema gerencia diferentes tipos de itens de uma biblioteca, como livros e DVDs, aplicando regras de negócio para empréstimos e multas.

🚀 Tecnologias Utilizadas
C# 12

.NET 8 (ou 9)

Console Application

🧠 Conceitos de POO Aplicados
Neste projeto, foquei em demonstrar os quatro pilares da POO:

Abstração: Criação da classe base ItemBiblioteca contendo propriedades essenciais como Titulo e ValorEmprestimo.

Herança: As classes Livros e Dvd herdam atributos e comportamentos da classe base, reaproveitando código.

Polimorfismo: Sobrescrita de métodos (override) para que cada tipo de item exiba seus detalhes de forma personalizada e calcule multas específicas.

Encapsulamento: Uso de propriedades com modificadores de acesso (protected, private) para garantir que o estado dos itens (como a disponibilidade) só seja alterado por métodos autorizados.

🛠️ Funcionalidades
[x] Cadastro de Livros e DVDs com diferentes atributos.

[x] Listagem de acervo com status de disponibilidade (Sim/Não).

[x] Construtores inteligentes com repasse de parâmetros para a classe base (base).

[x] Tratamento de valores padrão para taxas de empréstimo.

💻 Como executar
Clone o repositório:

Bash

git clone https://github.com/seu-usuario/nome-do-repositorio.git
Entre na pasta do projeto:

Bash

cd nome-do-repositorio
Execute o projeto:

Bash

dotnet run