# Console Core

### Extensões dotnet para VSCode

### Reduzir acoplamento com inversão de controle (Criação da interface)

### Criação de projetos (Várias camadas)
$dotnet new -h (mostra todos projetos que são possíveis criar)

### Criar projeto classlib:
$dotnet new classlib -n GameTOP.Lib

### Criar projeto de solução (coleção de projetos):
$dotnet new sln -n GameTOP

### Criar projeto de interface:
$dotnet new classlib -n GameTOP.Interface

### Adicionar referência ao projeto:
$dotnet add GameTOP/GameTOP.csproj reference GameTOP.Lib/GameTOP.Lib.csproj
$dotnet add GameTOP/GameTOP.csproj reference GameTOP.Interface/GameTOP.Interface.csproj

### Adicionar interface no projeto lib:
$dotnet add GameTOP.Lib/GameTOP.Lib.csproj reference GameTOP.Interface/GameTOP.Interface.csproj

### Adicionar projetos a solução:
$dotnet sln GameTOP.sln add GameTOP/GameTOP.csproj GameTOP.Lib/GameTOP.Lib.csproj
$dotnet sln GameTOP.sln add GameTOP.Interface/GameTOP.Interface.csproj

### Restaurar os projetos (Leva em consideração a solução e os projetos, analisa tudo limpa as dll e cria todas elas novamente (Rebuild)):
$dotnet restore

### Faça as referencias using para os projetos e em seguida restaure novamente

### Rodar um projeto específico:
$dotnet run --project GameTop/GameTOP.csproj

### Rodar um projeto escutando arquivos
$dotnet watch run