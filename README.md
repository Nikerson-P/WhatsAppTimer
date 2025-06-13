# WhatsAppTimer 🚀

Automatize o envio de links no WhatsApp Web utilizando C# e Selenium com agendamento inteligente.

---

## 🧠 Descrição

Este projeto permite que você programe o envio automático de mensagens (links, textos) para grupos ou contatos específicos no WhatsApp Web.

- Abre o navegador (Chrome) via Selenium.
- Redireciona para o chat desejado (download ou busca).
- Agende mensagens para envio em horários programados.
- Ótimas opções para compartilhar promoções, lembretes e conteúdos.

---

## 🔧 Requisitos

- [.NET 6+](https://dotnet.microsoft.com/)
- [ChromeDriver](https://sites.google.com/a/chromium.org/chromedriver/) compatível com sua versão do Chrome
- Pacotes NuGet:
  - `Selenium.WebDriver`
  - `Selenium.WebDriver.ChromeDriver`

---

## ⚙️ Instalação e execução

1. Clone este repositório:

    ```bash
    git clone https://github.com/Nikerson-P/WhatsAppTimer.git
    cd WhatsAppTimer
    ```

2. Restaure os pacotes:

    ```bash
    dotnet restore
    ```

3. Edite o arquivo `appsettings.json` ou ajuste no código:
   - **Grupo**: nome exato do grupo do WhatsApp.
   - **Links e horário**: defina o link a ser enviado e o momento de envio.

4. Execute:

    ```bash
    dotnet run
    ```

5. Ao abrir o Chrome, escaneie o QR Code do WhatsApp Web (uma única vez por sessão).

---

## 🔑 Funcionalidades principais

- **Agendamento de envio**: programe mensagens para horários específicos.
- **Envio em grupo ou contato**: suporte a múltiplos destinos.
- **Validações** em tempo real: confirma via DOM se o chat foi aberto com sucesso.
- **Loop automático**: checa minuto a minuto para envios pendentes no banco JSON ou SQLite.

---

## ⚠️ Observações

- Evite usar para spam ou envio massivo — pode resultar em bloqueio de conta.
- Para evitar reescaneamento do QR Code, utilize um perfil de usuário fixo do Chrome.

---

## 🛠 Melhorias sugeridas

- Interface gráfica simples (WinForms/WPF).
- Banco de dados robusto (SQLite/EF Core).
- Suporte a envio de imagens, vídeos ou PDFs.
- Logs detalhados, retries e tratamento de erros.
- Execução como serviço em background.

---

## 📄 Licença 

Este projeto é distribuído sob a licença MIT.  

---
