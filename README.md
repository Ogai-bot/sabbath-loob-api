# sabbath-loop-api

O objetivo geral do projeto é auxiliar os professores e lideres na gerencia do dados do CRM (Comunhão, Relacionamento e Missão) dos membros de uma classe de Escola Sabatina. Para isso o projeto deve ser capaz de receber a resposta ao CRM de cada membro, tratar e armazenar tais respostas e permitir que os professores e lideres tenham acesso a tais dados de forma organizada e facil;

Os objetivos especificos são:
- CRUD dos membros;
- Receber resposta ao CRM de cada membro de forma individual;
- Permitir que o membro tenha acesso a suas respostas;
- Permitir que os professores e lideres tenham acesso aos dados de seus liderados;

Perguntas:
- Vc esteve presente na Escola Sabatina? (WasPresent?)
- Vc estudou a palavra de Deus diariamente essa semana? (DailyCommunion?)
- Vc praticou alguma ação solidária essa semana (ajudou alguém)? (HelpedSomeone?)
- Essa semana, você falou de Deus, pessoalmente ou pelas redes sociais, para alguém? (TalkedAboutGod?)
- Vc está discipulado alguém por meio de estudos bíblicos? (TeachingSomeone?)
- Vc levou alguém ao batismo neste ano? (BaptizedSomeoneThisYear?)
- Vc está discipulado alguém? (DiscipleSomeone?)

### Rascunho 1

Tabelas (entidades):
- Companies
  - Id
  - Name
  - CreationDate
  - LastModified
- Churches
  - Id
  - Name
  - CompanyId
  - CreationDate
  - LastModified
- Classes
  - Id
  - Name
  - CompanyId
  - ChurchId
  - CreationDate
  - LastModified
- Quarters
  - Id
  - Name
  - CompanyId
  - StartDate
  - EndDate
  - CreationDate
  - LastModified
- Users
  - Id
  - Name
  - Email
  - Password
  - AskNewPassword
  - HasConfirmedEmail
  - TermsAcceptanceDate
  - TermsAcceptanceIp
  - CompanyId
  - CreationDate
  - LastModified
- UserAccessClasses
  - Id
  - UserId
  - ClassId
  - CompanyId
  - HasAccess
  - CreationDate
  - LastModified
- Members
  - Id
  - Name
  - Email
  - Password
  - AskNewPassword
  - HasConfirmedEmail
  - TermsAcceptanceDate
  - TermsAcceptanceIp
  - CompanyId
  - CreationDate
  - LastModified
- Responses
  - Id
  - MemberId
  - ClassId
  - ChurchId
  - CompanyId
  - WasPresent
  - DailyCommunion
  - HelpedSomeone
  - TalkedAboutGod
  - TeachingSomeone
  - BaptizedSomeoneThisYear
  - DiscipleSomeone
  - CreationDate
  - LastModified
