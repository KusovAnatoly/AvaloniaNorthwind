<a id="readme-top"></a>

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/KusovAnatoly/AvaloniaNorthwind/tree/main/AvaloniaNorthwind">
    <img src="Images/logo.svg" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Avalonia Northwind</h3>

  <p align="center">
    ERP-приложение на основе технологий .NET, C#, Avalonia, EF Core, PostgreSQL
    <br />
    <a href="https://github.com/KusovAnatoly/AvaloniaNorthwind/tree/main/AvaloniaNorthwind"><strong>Исследуйте исходный код здесь »</strong></a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Содержание</summary>
  <ol>
    <li>
      <a href="#о-проекте">О проекте</a>
      <ul>
        <li><a href="#сделано-с">Сделано с</a></li>
      </ul>
    </li>
    <li>
      <a href="#начало">Начало</a>
      <ul>
        <li><a href="#предусловия">Предусловия</a></li>
        <li><a href="#установка">Установка</a></li>
      </ul>
    </li>
    <li><a href="#использование">Использование</a></li>
    <li><a href="#контакт">Контакт</a></li>
    <li><a href="#благодарность">Благодарность</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## О проекте

[![Product Name Screen Shot][product-screenshot]](https://raw.githubusercontent.com/KusovAnatoly/AvaloniaNorthwind/refs/heads/main/Images/App%20Screenshot.png)

Это учебное приложение демонстрирует разработку настольного приложения на основе базы данных Northwind с использованием современных технологий, таких как .NET 8, Entity Framework Core, Avalonia и PostgreSQL. Приложение служит примером для студентов, как интегрировать различные слои приложения — от базы данных до пользовательского интерфейса.


<p align="right">(<a href="#readme-top">наверх</a>)</p>



### Сделано с

* [![.NET][dotnet-logo]][dotnet-url]
* [![EF Core][efcore-logo]][efcore-url]
* [![C #][csharp-logo]][csharp-url]
* [![Avalonia][avalonia-logo]][avalonia-url]
* [![PostgreSQL][postgres-logo]][postgres-url]

<p align="right">(<a href="#readme-top">наверх</a>)</p>


<!-- GETTING STARTED -->
## Начало

Чтобы запустить у себя проект вам необходимо будет выполнить действия ниже.

### Предусловия

* Visual Studio
  * Установите [Visual Studio Community 2022](https://visualstudio.microsoft.com/)
  * Установите следующие Рабочие нагрузки (Workloads) в *Visual Studio **Installer***
    * Разработка приложений для рабочего стола (.NET Desktop development)
  * Установите расширение [Avalonia for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.AvaloniaVS)
* PostgreSQL
  * Ознакомьтесь с вводным курсом по работе с [pgAdmin и PostgreSQL](https://metanit.com/sql/postgresql/)
  * Установите СУБД [PostgreSQL](https://www.postgresql.org/download/) и все необходимые компоненты (CLI Tools и pgAdmin)
  * Создайте базу данных и заполните ее данными с помощью [скрипта](https://github.com/pthom/northwind_psql/blob/master/northwind.sql)

### Установка

1. Склонируйте репозиторий в удобное место (см. [инструкцию](https://github.com/KusovAnatoly/git.git))
   ```sh
   git clone https://github.com/KusovAnatoly/AvaloniaNorthwind.git
   ```

2. Соберите решение
   ```sh
   dotnet build
   ```

<p align="right">(<a href="#readme-top">наверх</a>)</p>



<!-- USAGE EXAMPLES -->
## Object-Relational Mapper

Чтобы делать запросы к базе данных из проекта, вам потребуется технология, называемая Object-Relational Mapper (ORM), которая организовывает процесс создания подключения к СУБД, перевода запросов на [LINQ](https://learn.microsoft.com/en-us/dotnet/csharp/linq/) в SQL и преобразования таблиц в классы.

Мы будем использовать ORM от компании Microsoft под названием *Entity Framework Core*.

> Чтобы ORM работала, необходимо создать модели данных и контекст подключения к ней, задать правила преобразования типов и другие параметры, в случае существования готовой базы данных, эту задачу можно автоматизировать с помощью реверсивного инжиниринга, то есть процесса реконструирования базы данных, в этом случае для вашего проекта будут автоматически сгенерированы модели для таблиц из вашей базы данных с контекстом и другими необходимыми параметрами. Сделать это можно с помощью команды .NET CLI `scaffold`, которая работает только в том случае, если вы установите дополнительные инструменты для .NET CLI - Entity Framework Core Tools. Для более подробной см. [документацию Microsoft](https://learn.microsoft.com/en-us/ef/core/cli/dotnet).

1. Выполните команду
    ```sh
    dotnet tool install --global dotnet-ef
    ```

2. Выполните команду
    ```sh
    dotnet ef dbcontext scaffold "Server=127.0.0.1;Port=5432;Database=DATABASE_NAME;User Id=DBMS_USER;Password=DBMS_USER_PASSWORD;" --context-dir Data --output-dir Models Npgsql.EntityFrameworkCore.PostgreSQL
    ```
Не забудьте заменить в тексте команды `DATABASE_NAME` на имя свой базы данных, `DBMS_USER` на имя пользователя в СУБД, `DBMS_USER_PASSWORD` на пароль пользователя СУБД.  
Для более подробной информации см. [документацию Microsoft](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/)_

<p align="right">(<a href="#readme-top">наверх</a>)</p>

<!-- CONTACT -->
## Контакт

Анатолий Кусов - [@KusovAnatoly](https://t.me/KusovAnatoly) - kusov.anatoly@gmail.com

Ссылка на проект: [https://github.com/KusovAnatoly/AvaloniaNorthwind](https://github.com/KusovAnatoly/AvaloniaNorthwind)

<p align="right">(<a href="#readme-top">наверх</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Благодарность

* [Choose an Open Source License](https://choosealicense.com)
* [Segoe Fluent Icons](https://learn.microsoft.com/ru-ru/windows/apps/design/style/segoe-fluent-icons-font)
* [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
* [Malven's Flexbox Cheatsheet](https://flexbox.malven.co/)
* [Malven's Grid Cheatsheet](https://grid.malven.co/)
* [Img Shields](https://shields.io)
* [GitHub Pages](https://pages.github.com)
* [Font Awesome](https://fontawesome.com)

<p align="right">(<a href="#readme-top">наверх</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/KusovAnatoly/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/KusovAnatoly/AvaloniaNorthwind/graphs/contributors

[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: Images/App%20Screenshot.png

[dotnet-logo]: https://img.shields.io/badge/dotnet-512BD4?style=for-the-badge&logo=dotnet&logoColor=fff
[dotnet-url]: https://dotnet.microsoft.com/

[csharp-logo]: https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=fff
[csharp-url]: https://github.com/dotnet/csharplang

[efcore-logo]: https://img.shields.io/badge/EF-512BD4?style=for-the-badge&logo=dotnet&logoColor=fff
[efcore-url]: https://github.com/dotnet/efcore

[postgres-logo]: https://img.shields.io/badge/PostgreSQL-699eca?style=for-the-badge&logo=postgresql&logoColor=ffffFF
[postgres-url]: https://www.postgresql.org/

[avalonia-logo]: https://img.shields.io/badge/Avalonia-FFFFFF?style=for-the-badge&logoColor=ffff&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0nMS4wJyBlbmNvZGluZz0nVVRGLTgnIHN0YW5kYWxvbmU9J25vJz8+PHN2ZyB3aWR0aD0nNDIuMTIyMDAyJyBoZWlnaHQ9JzQyLjEyNzk5OCcgZmlsbD0nbm9uZScgdmVyc2lvbj0nMS4xJyBpZD0nc3ZnOCcgc29kaXBvZGk6ZG9jbmFtZT0nTG9nby5zdmcnIGlua3NjYXBlOnZlcnNpb249JzEuMiAoZGMyYWVkYWYwMywgMjAyMi0wNS0xNSknIHhtbG5zOmlua3NjYXBlPSdodHRwOi8vd3d3Lmlua3NjYXBlLm9yZy9uYW1lc3BhY2VzL2lua3NjYXBlJyB4bWxuczpzb2RpcG9kaT0naHR0cDovL3NvZGlwb2RpLnNvdXJjZWZvcmdlLm5ldC9EVEQvc29kaXBvZGktMC5kdGQnIHhtbG5zPSdodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZycgeG1sbnM6c3ZnPSdodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2Zyc+PGRlZnMgaWQ9J2RlZnMxMic+PGZpbHRlciBzdHlsZT0nY29sb3ItaW50ZXJwb2xhdGlvbi1maWx0ZXJzOnNSR0InIGlua3NjYXBlOmxhYmVsPSdEcm9wIFNoYWRvdycgaWQ9J2ZpbHRlcjMyOScgeD0nLTAuMTAzMDg2ODgnIHk9Jy0wLjEwMzA2OTE3JyB3aWR0aD0nMS4yMDYxNzM4JyBoZWlnaHQ9JzEuMjA2MTM4Myc+PGZlRmxvb2QgZmxvb2Qtb3BhY2l0eT0nMC42Nzg0MzEnIGZsb29kLWNvbG9yPSdyZ2IoODAsODAsODApJyByZXN1bHQ9J2Zsb29kJyBpZD0nZmVGbG9vZDMxOScgLz48ZmVDb21wb3NpdGUgaW49J2Zsb29kJyBpbjI9J1NvdXJjZUdyYXBoaWMnIG9wZXJhdG9yPSdpbicgcmVzdWx0PSdjb21wb3NpdGUxJyBpZD0nZmVDb21wb3NpdGUzMjEnIC8+PGZlR2F1c3NpYW5CbHVyIGluPSdjb21wb3NpdGUxJyBzdGREZXZpYXRpb249JzEuNScgcmVzdWx0PSdibHVyJyBpZD0nZmVHYXVzc2lhbkJsdXIzMjMnIC8+PGZlT2Zmc2V0IGR4PScwJyBkeT0nMCcgcmVzdWx0PSdvZmZzZXQnIGlkPSdmZU9mZnNldDMyNScgLz48ZmVDb21wb3NpdGUgaW49J1NvdXJjZUdyYXBoaWMnIGluMj0nb2Zmc2V0JyBvcGVyYXRvcj0nb3ZlcicgcmVzdWx0PSdjb21wb3NpdGUyJyBpZD0nZmVDb21wb3NpdGUzMjcnIC8+PC9maWx0ZXI+PC9kZWZzPjxzb2RpcG9kaTpuYW1lZHZpZXcgaWQ9J25hbWVkdmlldzEwJyBwYWdlY29sb3I9JyNmZmZmZmYnIGJvcmRlcmNvbG9yPScjMDAwMDAwJyBib3JkZXJvcGFjaXR5PScwLjI1JyBpbmtzY2FwZTpzaG93cGFnZXNoYWRvdz0nMicgaW5rc2NhcGU6cGFnZW9wYWNpdHk9JzAuMCcgaW5rc2NhcGU6cGFnZWNoZWNrZXJib2FyZD0nMCcgaW5rc2NhcGU6ZGVza2NvbG9yPScjZDFkMWQxJyBzaG93Z3JpZD0nZmFsc2UnIGlua3NjYXBlOnpvb209JzEyLjEnIGlua3NjYXBlOmN4PScxNy45MzM4ODQnIGlua3NjYXBlOmN5PScyMS41NzAyNDgnIGlua3NjYXBlOndpbmRvdy13aWR0aD0nMTkyMCcgaW5rc2NhcGU6d2luZG93LWhlaWdodD0nMTAyNycgaW5rc2NhcGU6d2luZG93LXg9Jy04JyBpbmtzY2FwZTp3aW5kb3cteT0nLTgnIGlua3NjYXBlOndpbmRvdy1tYXhpbWl6ZWQ9JzEnIGlua3NjYXBlOmN1cnJlbnQtbGF5ZXI9J3N2ZzgnIC8+PHBhdGggZD0nbSAzNC4wNTIsMzguNTI4IGggMC4yMSBhIDQuMjU2LDQuMjU2IDAgMCAwIDQuMjMsLTMuNzUzIGwgMC4wMywtMTQuMTggQyAzOC4yNzMsMTEuMTY3IDMwLjU1MiwzLjYwMDAwMDIgMjEuMDY0LDMuNjAwMDAwMiAxMS40MTksMy42MDAwMDAyIDMuNjAwMDAwMSwxMS40MTkgMy42MDAwMDAxLDIxLjA2NCBjIDAsOS41NDIgNy42NTE5OTk5LDE3LjMgMTcuMTU0OTk5OSwxNy40NjQgeicgZmlsbD0nI2ZmZmZmZicgaWQ9J3BhdGgyJyBzdHlsZT0nZmlsdGVyOnVybCgjZmlsdGVyMzI5KScgLz48cGF0aCBmaWxsLXJ1bGU9J2V2ZW5vZGQnIGNsaXAtcnVsZT0nZXZlbm9kZCcgZD0nTSAyMS4xMSw5LjU0ODAwMDIgQyAxNS42MTMsOS41NDgwMDAyIDExLjAxNiwxMy40MDEgOS44NzIwMDAxLDE4LjU1NCBhIDIuNjAzLDIuNjAzIDAgMCAxIDAsNS4wMSBDIDExLjAxNiwyOC43MTggMTUuNjEyLDMyLjU3MSAyMS4xMSwzMi41NzEgYyAyLjAwMSwwIDMuODgzLC0wLjUxIDUuNTIyLC0xLjQwOSB2IDEuMzMgaCA1Ljk5IFYgMjEuNTM3IGMgMC4wMDUsLTAuMTQ1IDAsLTAuMzMgMCwtMC40NzcgMCwtNi4zNTcgLTUuMTU1LC0xMS41MTA5OTk4IC0xMS41MTIsLTExLjUxMDk5OTggeiBNIDE1LjU5NiwyMS4wNTkgYSA1LjUxNCw1LjUxNCAwIDEgMSAxMS4wMjgsMCA1LjUxNCw1LjUxNCAwIDAgMSAtMTEuMDI4LDAgeicgZmlsbD0nIzhiNDRhYycgaWQ9J3BhdGg0JyAvPjxwYXRoIGQ9J20gMTAuOTU0LDIxLjA1MiBhIDEuODQyLDEuODQyIDAgMSAxIC0zLjY4Mzk5OTksMCAxLjg0MiwxLjg0MiAwIDAgMSAzLjY4Mzk5OTksMCB6JyBmaWxsPScjOGI0NGFjJyBpZD0ncGF0aDYnIC8+PC9zdmc+
[avalonia-url]: https://github.com/AvaloniaUI/Avalonia

