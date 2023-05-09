## Problems

- Falta de testes automatizados
- Não dá pra refatorar sem testes
- Sem acesso a logs, fica tudo nos clientes
- Não sei se tem processos quebrando nas aplicações
- Sem monitoramento de erros e de performance
- Sem aprendizado com o software que tá rodando
- Postura totalmente reativa, dependente de reclamações no suporte
- Falta de ambientes de Dev, Staging, Test, Production
- Falta de Integração e de Deploy Contínuo
- Cada cliente tem um versão de cada aplicação
- Clientes sofrem com bugs já corrigidos em versões mais novas
- Deploys demorados e restritos a horário específico
- Grandes entregas, maior risco
- Qual o tempo médio que leva pra fazer uma entrega hoje?
- Falta de feedback rápido e aprendizado contínuo
- Legado e tecnologias antigas
- Escala pra mais clientes, demonstrações do software

## Solutions

- Começar com uma Prova de Conceito
- Pegar uma das aplicações (a mais desacoplada do restante) e levar pra nuvem
- Deixar rodando ela e a versão antiga tbm
- Mostrar aos usuários e medir o que eles acharam
- Precisamos ter um jeito de mensurar variáveis para comparar as duas abordagens
- Medir custos de infra, pra ver se compensa ir de um modelo pro outro
- Todo o aprendizado nesse projeto vai ser reaproveitado nos demais
- Vamos poder medir o esforço pra fazer esse projeto e os ganhos que ele trouxe
- Velocidade de desenvolvimento
- Escalabilidade horizontal
- Facilidade na adição de novas features e na manutenção
- Possibilidade de monitorar erros, logs, performance, gargalos...
- Deploy a qualquer momento do dia, todo mundo usando a versão mais nova do sistema
- Separação por ambientes de dev, staging, test e prod
- Na web já tem muita coisa pronta, soluções excelentes que bastam ser usadas no software
- Muitos dos problemas que formos enfrentar já foram resolvidos por outras pessoas
- Fica mais fácil fazer o onboarding de alguém no time, ou mesmo mudar os devs de time

## Tecnologias

- API com .NET 8 + EF
- Front com Next.js + MaterialUI
- Banco PostgreSQL
- Docker
- Azure DevOps
- Azure?

## DevOps

- Pessoas + Processos + Produtos => Entrega Contínua de Valor
- Fluxo, Feedback e Aprendizado Contínuo
- Planejar -> Dev + Test -> Release -> Monitorar e Aprender

## Multi Tenancy e SAAS

- Um banco -> cada cliente tem seu schema
- Uma instância -> Cada cliente tem um banco
- Cada cliente tem uma instâmcia (On Premises)

## 12 Factor App

- Apps modernos precisam ser flexíveis quanto infra, escaláveis horizontalmente e passíveis de serem deployados continuamente
- Cloud Native App = Conteinerização + Orquestração + Automação
- I = One Codebase (git repo) => deploy in many environments
- II = Explicitly declare and isolate dependencies (use Docker, Nuget...)
- III = Config (store config in the environment variables / Azure Key Vault)
- IV = Backing Services (plugable services - redis, db, s3, email)
- V = Separate build - release - run
- VI = Processes (statelles processes)
- VII = Port Binding
- VIII = Concurrency (statelles for horizontal scalling)
- IX = Disposability
- X = Dev/Prod parity
- XI = Logs
- XII = Admin Processes

## Continuous Delivery

- Add tests (unit, integration, regression, approval)
- Refactor in small steps, all the time
- Improve speed of feedback
- Automate deployment (infra as code)
