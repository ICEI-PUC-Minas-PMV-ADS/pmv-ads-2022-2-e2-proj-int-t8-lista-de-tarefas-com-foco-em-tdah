# Plano de Testes de Software



Esses são os cenários de testes utilizados na realização dos testes da aplicação. 
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-7 - O sistema deve permitir que os usuário criem e façam login em seus perfis. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador. <br> - Informar o endereço da aplicação. <br> - Clicar em "Criar conta". <br> - Preencher os campos obrigatórios.  <br>  - Clicar em "Registrar". |
|Critério de Êxito | - Mensagem informando que o cadastro foi realizado com sucesso. <br> - Inserção no banco de dados o usuário criado. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-7	- O sistema deve permitir que os usuário criem e façam login em seus perfis. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login e se a aplicação está segura. |
| Passos 	| - Acessar o navegador. <br> - Informar o endereço da aplicação.  <br> - Preencher o campo de e-mail. <br> - Preencher o campo da senha. <br> - Clicar em "Login". |
|Critério de Êxito | - Acessar perfil do usuário. <br> - Não permitir o acesso com dados incorretos. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Criação e configurações das tarefas**	|
|Requisito Associado | RF-1 - O sistema deve ter um campo para digitar as tarefa do usuário.<br> RF-2 - O sistema deve ter um botão para confirmar as tarefa e suas configurações. <br> RF-5 - O sistema deve permitir a configurações de data e horário para as tarefas que o usuário desejar. <br> RF-9	- O sistema deve permitir organizar as tarefas por grupos (Ex: Trabalho, estudos, filmes para assistir.). |
| Passos 	| - Acessar o navegador. <br> - Informar o endereço da aplicação. <br> - Preencher o campo de e-mail. <br> - Preencher o campo da senha. <br> - Clicar em "Login". <br> - Criar tarefa. |
|Critério de Êxito | - Apresentação de campo editável para inserção dos dados da tarefa. <br> - Apresentação de botão para confirmação das tarefas e suas configurações. <br> - Apresentação de calendário e relógio para a seleção da data e horário desejado para a tarefa. <br> - Apresentação de lista selecionável dos tipos de tarefa possível. <br> - Inserção no banco de dados a tarefa e suas configurações.|
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Confirmação, exclusão e conclusão das tarefas recebidas**	|
|Requisito Associado | RF-3 - O sistema deve ter um campo para receber as tarefas confirmadas. <br> RF-4 -	O sistema deve ter um botão para conclusão e exclusão das tarefas recebidas.  |
| Objetivo do Teste 	| Verificar a confirmação, exclusão e conclusão das tarefas. |
| Passos 	| - Acessar o navegador. <br> - Informar o endereço da aplicação. <br> - Preencher o campo de e-mail. <br> - Preencher o campo da senha. <br> - Clicar em "Login". <br> - Gerenciar tarefas. |
|Critério de Êxito | - Apresentação de botões para exclusão,confirmação,conclusão das tarefas. <br> - Exibição de mensagem confirmando o evento. <br>  - Alteração no banco de dados o status da tarefa. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Alerta para tarefas**	|
|Requisito Associado | RF-6	- O sistema deve emitir um alerta para tarefas que tiverem data e horários definidos, sendo 1 dia ou 30 minutos respectivamente. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço da aplicação <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - Aplicação apresenta mensagem de lembrete no horário programado. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Contador Pomodoro**	|
|Requisito Associado | RF-8 	O sistema deve ter um botão que permita a configuraçao de um contador pomodoro. |
| Objetivo do Teste 	| Verificar funcionamento do contador pomodoro. |
| Passos 	| - Acessar o navegador. <br> - Informar o endereço da aplicação. <br> - Preencher o campo de e-mail. <br> - Preencher o campo da senha. <br> - Clicar em "Login". <br> - Acessar contador pomodoro. |
|Critério de Êxito | - A aplicação deve apresentar um contador pomodoro funcional que emita alertas. |
 
