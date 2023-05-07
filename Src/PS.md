# Problems And Solutions

- Falta de testes automatizados
- Não dá pra refatorar sem testes
- Sem acesso a logs, fica tudo nos clientes
- Não sei se tem processos quebrando nas aplicações
- Sem monitoramento de erros e de performance
- Sem aprendizado com o software que tá rodando
- Postura totalmente reativa, dependente de reclamações no suporte
- Falta de ambientes de Staging, Testes, Production
- Falta de Integração e de Deploy Contínuo
- Cada cliente tem um versão de cada aplicação
- Clientes sofrem com bugs já corrigidos em versões mais novas
- Deploys demorados e restritos a horário específico
- Grandes entregas, maior risco
- Falta de feedback rápido e aprendizado contínuo
- Legado e tecnologias antigas
- Escala pra mais clientes, demonstrações do software

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
- I = One Codebase (git repo)
- II = Explicitly declare and isolate dependencies (use Docker)
- III = Config (store config in the environment variables)
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
