# Design Patterns
###
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
- **Problema**: Sua aplicação possui a criação de objetos com muitas regras de negócio, métodos com muitos parâmetros, ferindo a clareza do código e se enquadrando no *code smell Long parameter list*. Criar várias subclasses usando herança podemos deixar tudo muito complexo.
- **Solução**: O Builder resolve o problema da construção de objetos complexos. Devemos quebrar o processo de criação em várias etapas, a ordem da criação pode ser guiada por uma classe denominada *Director*, que conhece todas as etapas de criação.

### Adapter
- **Problema**: Sua aplicação possui implementação de métodos de pagamento utilizando o sistema *XPayment*, mas agora a nova demanda é realizar os pagamentos com o sistema *YPayment*, o problema é que esse novo meio de pagamento possui métodos diferentes com nomes diferentes.
- **Solução**: Devemos converter a interface do *YPayment* de maneira que o *XPayment* possa compreender as informações. O Adapter "encobre" um dos objetos de forma com que esconda as regras de negócio e qualquer dificuldade de conversão. O Objeto "encoberto" não fica ciente do adapter, permitindo assim com que classes incompatíveis trabalhem juntas.

### Bridge
- **Problema**: Sua aplicação gerencia transmissões de *streaming* para a plataforma *AStreaming*, mas agora anova demanda é realizar *streaming* para a platagorma *BStreaming*. Seria possível a criação de novas classes com métodos para a nova plataforma, mas isso iria ferir alguns princípios SOLID.
- **Solução**: Todas as plataformas de *Streaming* utilizam mecanismos e conceitos em comum, podemos então dividir uma classe com muitos métodos em várias classes. O Bridge é uma padrão estrutural que permite a divisão em duas hierarquias, sendo, abstração e implementação. A implementação do Bridge se assimila ao adapter, contudo de uma forma planejada.

### Chain of responsibility
- **Problema**: Sua aplicação realiza várias validações para requisições recebidas. A primeira validação é a autenticação do usuário, caso essa validação falhe a aplicação não deve prosseguir com a requisição, e o processamento deve ser interrompido.
- **Solução**: Padrões de projetos comportamentais aplicam o conceito de *Handlers* para os seus manipuladores. O Chain of responsibility sugere que os *Handlers* estejam ligados como uma corrente, ao se finalizar o processamento do *handler* atual, deve-se chamar o próximo *handler*, como se fosse o próximo ela da corrente, passando o objeto em comum.

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
