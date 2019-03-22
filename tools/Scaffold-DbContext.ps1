Set-Location ../src
dotnet ef dbcontext `
scaffold Name=Default Microsoft.EntityFrameworkCore.SqlServer `
    --project Magicodes.Simple.Services.Host `
    --output-dir ../Magicodes.Simple.Services.Core/Models --force

#  指定表
# --table Artist --table Album

Set-Location ../tools