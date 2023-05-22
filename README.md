# Design Patterns

> 🚀 Conhecer os padrões de projeto é fundamental para entender os modernos frameworks e desenvolver softwares melhores. Os padrões resultam em inúmeras vantagens, como exemplo, a melhora na comunicação da equipe de desenvolvimento, resoluções para problemas já existentes no código, flexibilidade e qualidade do código.

### Os padrões de projeto são divididos em 3 categorias:
- **Criacionais**: Se relaciona com o mecanismo de criação de objetos e a ideia de tornar flexíveis.
- **Estruturais**: Organiza as estruturas trabalhando com classes e objetos.
- **Comportamentais**: Trabalham com a comunicação eficiente, definindo as responsabilidades dos objetos.

### Factory Method
- **Problema**: Sua aplicação está toda estruturada para realizar entregas com carros, mas agora existe uma atual demanda para realizar entregas com motos e biciletas.
- **Solução**: Substituir as chamadas (new) das classes concretas para um método intermediário que irá "fabricar" as classes concretas.

### Abstract Factory
- **Problema**: Sua aplicação gerencia transportes, contudo a atual demanda é de um marketplace de transportes. A aplicação vai precisar prever quais tipos de transportes estão disponíveis para cada empresa cadastrada no marketplace.
- **Solução**: Declarar as interfaces para cada produto compondo uma "família" de produtos, como exemplo, IVeiculos e IAeronaves. Todas as variantes dos produtos devem implementar a interface. A próxima etapa será declarar a "fábrica abstrata", ou seja, uma Interface que possui uma lista de métodos de criação para todos os produtos que fazem parte da "família", os métodos retornam tipos abstratos que representam os produtos. E como fazer para cada cliente do marketplace? Teremos uma classe fábrica que implementa a "fábrica abstrata" com os métodos de criação.

### Builder

### Adapter

### Bridge

### Chain of responsibility

### 😎 Autor

Guilherme Ferrari - guile.ferrari@hotmail.com

[![Linkedin Badge](https://img.shields.io/badge/-Guilherme-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/guilherme-antonio-ferrari/)](https://www.linkedin.com/in/guilherme-antonio-ferrari/)

### 🎯 Contribuição

1. Faça o _fork_ do projeto
2. Crie uma _branch_ para sua modificação (`git checkout -b feature/descricaoFeature`)
3. Faça o _commit_ (`git commit -am 'Add descricaoFeature'`)
4. _Push_ (`git push origin feature/descricaoFeature`)
5. Crie um novo _Pull Request_

### 📝 Licença

MIT.