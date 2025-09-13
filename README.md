# API Blueprint Template

Este repositório contém um **template de API em .NET 8** para inicializar rapidamente novos projetos.  
O pacote está disponível de forma privada no **GitHub Packages**.

---

## 📦 Como consumir o pacote

### 1. Configure a source do GitHub Packages
No terminal, adicione o repositório do seu usuário/organização como fonte do NuGet:

```bash
dotnet nuget add source "https://nuget.pkg.github.com/<SEU_USUARIO_OU_ORG>/index.json" \
    --name github \
    --username <SEU_USUARIO_OU_ORG> \
    --password <TOKEN_GITHUB> \
    --store-password-in-clear-text
