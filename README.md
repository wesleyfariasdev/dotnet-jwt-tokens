# JwtTokenApp.Api

Aplicação exemplo em **.NET 8** demonstrando a geração de **JSON Web Tokens (JWT)** utilizando o algoritmo **HS256** com chave simétrica.  
Este projeto é uma API simples para autenticação de heróis fictícios, com geração de tokens que incluem claims personalizadas.

## 🔑 Principais Tecnologias

- ASP.NET Core 8 (API)
- JWT (JSON Web Token)
- Algoritmo de assinatura HS256
- Injeção de Dependência
- Validação de Claims
- Configuração via \`appsettings.json\`

---

## 🚀 Como Executar o Projeto

### ✅ Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VSCode](https://code.visualstudio.com/)

### ⚙️ Configuração Inicial

1. **Clone o repositório:**

```bash
git clone https://github.com/wesleyfariasdev/dotnet-jwt-tokens.git
```

2. **Acesse o diretório do projeto:**

```bash
cd dotnet-jwt-tokens/JwtTokenApp.Api
```

3. **Restaure os pacotes:**

```bash
dotnet restore
```

4. **Execute o projeto:**

```bash
dotnet run
```

---

## ⚙️ Configuração do \`appsettings.json\`

Exemplo de configuração para JWT:

```json
"JwtSettings": {
  "SecretKey": "V2l0ZXJTaG91bGQgU2VjcmV0S2V5U2VjdXJlVG9rZW5Qb3NpdGl2ZUNvZGVkZWQ=",
  "Issuer": "Heroi Api",
  "Audience": "Audiencia",
  "ExpirationTimeMinutes": "1",
  "RefresheExpirationMinutes": "20"
}
```

> ⚠️ **Importante:** A \`SecretKey\` precisa ter pelo menos 256 bits (32 bytes) codificados em Base64 para o HS256 funcionar corretamente.

---

## ✅ Como Usar

### 🎯 Rota de Geração de Token

- **POST** \`/api/auth\`

#### Corpo da Requisição (JSON):

```json
{
  "nome": "Homem Normal"
}
```

#### Retorno:

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

### 🔒 Token contém as Claims:

- \`sub\` (nome do herói)
- \`jti\` (ID único do token)
- \`role\` (papéis/poderes do herói)

---

## 💡 Sobre o Projeto

Este projeto tem como objetivo servir de exemplo prático para:

- Como gerar JWT em .NET.
- Como trabalhar com claims e roles dinâmicos.
- Como configurar JWT e Secret Keys corretamente com HS256.

---

## 🛡️ Segurança

- Utilize **chaves fortes e secretas** (mínimo de 256 bits).
- Nunca exponha o \`appsettings.json\` com a chave real em repositórios públicos.

---

## 📂 Estrutura do Projeto

```
JwtTokenApp.Api
│
├── Autenticacao
│   └── TokenManager.cs      // Serviço para geração de JWT
│
├── Models
│   ├── Heroi.cs             // Modelo do Herói
│   └── Poder.cs             // Modelo dos poderes do Herói
│
├── Controllers
│   └── AuthController.cs    // Controller para autenticação e geração de token
│
└── appsettings.json         // Configurações do JWT
```

---

## 📃 Licença

Este projeto está licenciado sob a licença **MIT**.
