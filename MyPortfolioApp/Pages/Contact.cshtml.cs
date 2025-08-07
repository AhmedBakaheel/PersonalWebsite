using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations; // áÅÖÇİÉ ÇáÊÍŞŞ ãä ÕÍÉ ÇáãÏÎáÇÊ

namespace MyPortfolioApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty] // áÑÈØ ÇáÎÕÇÆÕ ÈãÏÎáÇÊ ÇáäãæĞÌ
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "ÇáÇÓã ãØáæÈ.")]
            [StringLength(100, ErrorMessage = "ÇáÇÓã íÌÈ ÃáÇ íÊÌÇæÒ 100 ÍÑİ.")]
            [Display(Name = "ÇÓãß ÇáßÇãá")] // ÇáäÕ ÇáĞí íÙåÑ ÈÌÇäÈ ÍŞá ÇáÅÏÎÇá
            public string Name { get; set; }

            [Required(ErrorMessage = "ÇáÈÑíÏ ÇáÅáßÊÑæäí ãØáæÈ.")]
            [EmailAddress(ErrorMessage = "ÕíÛÉ ÇáÈÑíÏ ÇáÅáßÊÑæäí ÛíÑ ÕÍíÍÉ.")]
            [Display(Name = "ÈÑíÏß ÇáÅáßÊÑæäí")]
            public string Email { get; set; }

            [Required(ErrorMessage = "ÇáÑÓÇáÉ ãØáæÈÉ.")]
            [StringLength(500, ErrorMessage = "ÇáÑÓÇáÉ íÌÈ ÃáÇ ÊÊÌÇæÒ 500 ÍÑİ.")]
            [Display(Name = "ÑÓÇáÊß")]
            public string Message { get; set; }
        }

        [TempData] // áÍİÙ ÇáÈíÇäÇÊ Èíä ÇáØáÈÇÊ HTTP (áÅÙåÇÑ ÑÓÇáÉ ÈÚÏ ÅÚÇÏÉ ÇáÊæÌíå)
        public string MessageSent { get; set; } // áÚÑÖ ÑÓÇáÉ ÊÃßíÏ ÇáÅÑÓÇá

        public void OnGet()
        {
            // áÇ íæÌÏ ãäØŞ ÎÇÕ ÚäÏ ÊÍãíá ÇáÕİÍÉ áÃæá ãÑÉ
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) // ÇáÊÍŞŞ ãä ÕÍÉ ÇáÈíÇäÇÊ ÇáãÏÎáÉ
            {
                return Page(); // ÅĞÇ ßÇäÊ ÇáÈíÇäÇÊ ÛíÑ ÕÍíÍÉ¡ ÃÚÏ ÚÑÖ äİÓ ÇáÕİÍÉ ãÚ ÃÎØÇÁ ÇáÊÍŞŞ
            }

            // åäÇ íãßäß ÚÇÏÉğ ÅÑÓÇá ÇáÈÑíÏ ÇáÅáßÊÑæäí Ãæ ÍİÙ ÇáÈíÇäÇÊ İí ŞÇÚÏÉ ÇáÈíÇäÇÊ.
            // İí åĞÇ ÇáãËÇá¡ ÓäŞæã İŞØ ÈÊÚííä ÑÓÇáÉ äÌÇÍ.

            // ãËÇá áØÈÇÚÉ ÇáÈíÇäÇÊ İí æÍÏÉ ÇáÊÍßã (Console) áãÌÑÏ ÇáÇÎÊÈÇÑ
            Console.WriteLine($"ÑÓÇáÉ ÌÏíÏÉ ãä: {Input.Name}");
            Console.WriteLine($"ÇáÈÑíÏ ÇáÅáßÊÑæäí: {Input.Email}");
            Console.WriteLine($"ÇáÑÓÇáÉ: {Input.Message}");

            MessageSent = "Êã ÇÓÊáÇã ÑÓÇáÊß ÈäÌÇÍ! ÓÃÊæÇÕá ãÚß ŞÑíÈÇğ.";
            return RedirectToPage(); // ÅÚÇÏÉ ÊæÌíå ÇáãÓÊÎÏã áäİÓ ÇáÕİÍÉ ÈÚÏ ÇáÅÑÓÇá
        }
    }
}