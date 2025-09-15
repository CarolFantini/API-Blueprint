# API Blueprint Template

Este repositório contém um **template de API em .NET 8** para inicializar rapidamente novos projetos. O pacote está disponível de forma privada no **GitHub Packages**.

---

## 📦 Como consumir o pacote

### 1. Configure a source do GitHub Packages
No terminal, adicione o repositório do seu usuário/organização como fonte do NuGet:

```bash
dotnet nuget add source "https://nuget.pkg.github.com/CarolFantini/index.json" \
    --name github \
    --username <SEU_USUARIO_OU_ORG> \
    --password <TOKEN_GITHUB> \
    --store-password-in-clear-tex
````

### 2. Instale o pacote
Depois de configurar a source, você pode instalar o pacote normalmente:

```bash
dotnet new install MinhaEmpresa.API.Blueprint::<versão>
````
ou, se for consumir como biblioteca NuGet:
```bash
dotnet add package MinhaEmpresa.API.Blueprint --version <versão>
````

### 3. Atualizar o pacote
Para atualizar para a última versão:

```bash
dotnet new update
````
ou
```bash
dotnet add package MinhaEmpresa.API.Blueprint --version x.y.z
````
