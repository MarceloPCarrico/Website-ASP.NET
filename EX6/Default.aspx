<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EX6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main style="max-width: 1200px; margin: 0 auto; background-color: #333; color: #fff; padding: 20px;">

        <section class="welcome-section" style="text-align: center;">
            <h1>Bem-vindo ao Sistema de Gestão Escolar</h1>
            <p> Desenvolvi este site dinâmico com ASP.NET e C#, utilizando uma base de dados composto por múltiplas tabelas relacionadas para uma gestão eficiente de dados. Na construção da webpage foi realizada pela utilização de Bootstrap e HTML, proporcionando uma experiência de utilizador intuitiva e agradável. </p>
        </section>

        <section class="feature-section" style="display: flex; justify-content: space-around; margin-top: 20px;">

            <div class="feature" style="text-align: center; background-color: #444; padding: 20px; border-radius: 8px; flex: 1;">
                <img src="https://noticias.uc.pt/site/assets/files/378192/patio_das_escolas-006-felippe_vaz-20210504.jpg" alt="Inserir Aluno" style="max-width: 100%; height: auto; border-radius: 8px;">
                <h2>Novos Alunos</h2>
                <p>Damos as boas-vindas aos novos estudantes, convocando a exploração das suas histórias e singularidades. Neste templo do saber, cada estudante é uma nota única, entoando a melodia da aprendizagem. Que este encontro com o conhecimento seja um convite à introspeção e ao florescer intelectual, contribuindo para a sinfonia magnífica do saber.</p>
            </div>
            <div class="feature" style="text-align: center; background-color: #444; padding: 20px; border-radius: 8px; flex: 1;">
                <img src="https://i.pinimg.com/originals/e3/95/f5/e395f57e96281293880f76b9bfb5a641.jpg" alt="Gerir Alunos Existentes" style="max-width: 100%; height: auto; border-radius: 8px;">
                <h2>Gerir Matrículas</h2>
                <p>Navegue e gerencie facilmente os perfis dos alunos já registados. Atualize informações, verifique o progresso acadêmico, e esteja sempre atualizado sobre as mudanças na composição da turma. Atualize com destreza as informações inscritas, perscrute com agudeza o percurso académico de cada aluna e aluno, e mantenha-se em perpétua sintonia com as metamorfoses na composição desta comunidade.</p>
               
            </div>
        </section>

        <section class="delete-section" style="text-align: center; margin-top: 20px; background-color: #444; padding: 20px; border-radius: 8px;">
            <div class="delete-feature">
                <img src="https://www.cultuga.com.br/wp-content/uploads/2019/04/universidade-coimbra-estudantes-cultuga.jpg" alt="Eliminar Alunos" style="max-width: 100%; height: auto; border-radius: 8px;">
                <h2>Eliminar Alunos</h2>
                <p>Se necessário, remova alunos da turma. Esta opção permite uma gestão eficiente, garantindo que apenas informações relevantes e atualizadas estejam disponíveis.</p>
                
            </div>
        </section>
        
    </main>
</asp:Content>





