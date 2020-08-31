using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRdo.MVC.Helpers
{
    public static class ButtonsHelpers
    {
        public static IHtmlContent SubmitButton(this IHtmlHelper htmlHelper, string textButton)
        {
            var html = @"<div id='smart-rdo-submit'>
                            <input id='text-button' type='hidden' value='" + textButton + @"'/>
                        </div>";

            html += "<script src='/js/Helpers/SubmitButton.js'></script>";

            return new HtmlString(html);
        }
    }
}
