<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjetoIntegrador.Default" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>

        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.0/jquery.js"></script>
        <script type="text/javascript" src="/js/jquery.preload.min.js"></script>
        <script type="text/javascript">
            $(document).ready(function () {
                activePanel = $("#divAccordion div.panel:first");
                $(activePanel).addClass('active');
                $("#divAccordion").delegate('.panel', 'click', function (e) {
                    if (!$(this).is('.active')) {
                        $(activePanel).animate({ width: "44px" }, 300);
                        $(this).animate({ width: "896px" }, 300);
                        $('#divAccordion .panel').removeClass('active');
                        $(this).addClass('active');
                        activePanel = this;
                    };
                });
            });

            $.preload('/imagens/menus/principal_h.png',
                  '/imagens/menus/sobrenos.png',
                  '/imagens/menus/areaclientes.png',
                  '/imagens/menus/contatos.png'
            );

            function MostraLoader(obj,img) {
                $("#" + obj.id).hide();
                $("#" + img).show();
            }
        </script>
    </head>

    <body>
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <div id="divContainerH">
                <div id="divContainerV">
                    <div id="divCabecalho">
                        <div id="divLogo"></div>
                        <div id="divLogo2"></div>
                    </div>

                    <div id="divConteudo">
                        <div id="divAccordion">
                            <div class="panel Primeiro">
                                <div class="Titulo Primeiro"><div id="divSobreNos"></div></div>
                                <div class="Conteudo p1">
                                    <h4>Sobre nós</h4>
                                    <p>A Easy Sistemas é uma empresa de Tecnologia da Informação que está presente no mercado há 2 anos, atuando em diversos segmentos como Finanças, Varejo, Aviação, Telecomunicações, Serviços, Mercado Eletrônico e Setor Público.</p>
                                    <p>Contamos com uma equipe de profissionais altamente especializados e qualificados, com grande experiência em projetos de soluções para camada intermediária (Middleware), soluções de Inteligência de Negócios (BI), soluções de Infraestrutura (Application Server, Database e WebLogic) e plataforma de e-Commerce de nível internacional.</p>
                                    <p>A Easy é uma empresa que valoriza sua equipe, seus clientes e parceiros. Nosso comprometimento, dedicação e integridade, tem sido reconhecidos e valorizados por nossos clientes, fazendo com que a Easy esteja presente no crescimento.</p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="Titulo p2"><div id="divProdutos"></div></div>
                                <div class="Conteudo p2">
                                    <h4>Nossos produtos</h4>
                                    <p><span>Easy Help Desk:</span> Solução de gerenciamento para help desks, facilitando o atendimento ao usuário final e gerenciamento total do setor de suporte.</p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="Titulo"><div id="divAreaClientes"></div></div>
                                <div class="Conteudo p3">
                                    <h4>Área de clientes</h4>
                                    <p>Para você que já é nosso cliente, reservamos esse espaço para que possa acessar os nossos sistemas em sua versão web. Basta digitar abaixo o seu login e senha utilizados para entrar no sistema.</p>

                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                            <table style="width:400px;">
                                                <tr><td class="titulo">Usuário:</td>
                                                    <td><asp:TextBox ID="txtUsuario" runat="server" Width="230" /></td></tr>
                                                <tr><td class="titulo">Senha:</td>
                                                    <td><asp:TextBox ID="txtSenha" runat="server" Width="230" TextMode="Password" /></td></tr>
                                                <tr><td colspan="2" class="botao">
                                                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" OnClientClick="MostraLoader(this,'imgLoaderLogin');" Text="Efetuar login" />
                                                        <img src="/imagens/loader.gif" id="imgLoaderLogin" alt="Carregando..." style="display:none;" />
                                                    </td></tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    
                                </div>
                            </div>
                            <div class="panel Ultimo">
                                <div class="Titulo Ultimo"><div id="divContatos"></div></div>
                                <div class="Conteudo p4">
                                    <h4>Contato</h4>
                                    <p>Para entrar em contato conosco é simples e fácil. Você pode enviar um e-mail para atendimento@easysistemas.com.br ou se preferir pode preencher o formulário abaixo:</p>

                                    <table style="width:700px;">
                                        <tr><td class="titulo">Seu nome:</td>
                                            <td><asp:TextBox ID="txtNome" runat="server" Width="380" /></td></tr>
                                        <tr><td class="titulo">Seu telefone:</td>
                                            <td><asp:TextBox ID="txtTelefone" runat="server" Width="380" /></td></tr>
                                        <tr><td class="titulo">Seu e-mail:</td>
                                            <td><asp:TextBox ID="txtEmail" runat="server" Width="380" /></td></tr>
                                            <tr><td class="titulo">Mensagem:</td>
                                            <td><asp:TextBox ID="txtMensagem" runat="server" Height="120" Width="380" TextMode="MultiLine" /></td></tr>
                                        <tr><td colspan="2" class="botao">
                                                <asp:Button ID="btnContato" runat="server" OnClientClick="MostraLoader(this,'imgLoaderContato');" Text="Enviar contato" />
                                                <img src="/imagens/loader.gif" id="imgLoaderContato" alt="Carregando..." style="display:none;" />
                                            </td></tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div id="divRodape">
                        <div id="divRedesSociais">
                            <ul>
                                <li><img src="/imagens/social/facebook.png" alt="Facebook" /></li>
                                <li><img src="/imagens/social/twitter.png" alt="Twitter" /></li>
                                <li><img src="/imagens/social/google.png" alt="Google+" /></li>
                                <li><img src="/imagens/social/instagran.png" alt="Instagran" /></li>
                                <li><img src="/imagens/social/reddit.png" alt="Reddit" /></li>
                            </ul>
                        </div>
                        <p>Easy Systemas &copy 2013 - Todos os direitos reservados</p>
                    </div>
                </div>
            </div>
        </form>
    </body>
</html>
