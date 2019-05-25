//reference https://github.com/xceedsoftware/DocX
using GerarRelatorio.Entities;
using System;
using System.Drawing;
using Xceed.Words.NET;

namespace GerarRelatorio.Business
{
    public static class RelatorioPessoa
    {
        public static bool GerarRelatorio(RelatorioPessoaModel model)
        {
            bool result = false;
            try
            {
                using (DocX document = DocX.Create("../../../GerarRelatorio.Business/Documento/" + @"Relatório.docx"))
                {
                    // Adicionado um titulo
                    document.InsertParagraph("Relatório de Pessoa").FontSize(15d).SpacingAfter(50d).Alignment = Alignment.center;

                    //inserindo um paragrafo no documento
                    var pTitle = document.InsertParagraph();

                    //dando append no texto e formatando (subtitulo).
                    pTitle.Append("Dados da Pessoa")
                    .Font(new Xceed.Words.NET.Font("Arial"))
                    .FontSize(18)
                    .Color(Color.Black)
                    .Bold()
                    .SpacingAfter(40);

                    ///Dados das pessoa
                    var array = model.PropriedadesPessoa();
                    foreach (var item in array)
                    {
                        var p = document.InsertParagraph();
                        if (!item.Key.Contains("Descricao"))
                        {
                            p.Append(item.Key+":\t")
                           .Font(new Xceed.Words.NET.Font("Times New Roman"))
                           .Color(Color.Black)
                           .Bold()
                           .Append(item.Value)
                           .Font(new Xceed.Words.NET.Font("Times New Roman"))
                           .Color(Color.Black);
                        }
                        else
                        {
                            p.Append(item.Key+":\n")
                           .Font(new Xceed.Words.NET.Font("Times New Roman"))
                           .Color(Color.Black)
                           .Bold()
                           .Append(item.Value)
                           .Font(new Xceed.Words.NET.Font("Times New Roman"))
                           .FontSize(10)
                           .CapsStyle(CapsStyle.caps)
                           .Color(Color.Black);
                        }
                    }

                    // Salvando o codumento no diretório.
                    document.Save();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
