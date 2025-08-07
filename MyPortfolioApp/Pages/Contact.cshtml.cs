using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations; // ������ ������ �� ��� ��������

namespace MyPortfolioApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty] // ���� ������� ������� �������
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "����� �����.")]
            [StringLength(100, ErrorMessage = "����� ��� ��� ������ 100 ���.")]
            [Display(Name = "���� ������")] // ���� ���� ���� ����� ��� �������
            public string Name { get; set; }

            [Required(ErrorMessage = "������ ���������� �����.")]
            [EmailAddress(ErrorMessage = "���� ������ ���������� ��� �����.")]
            [Display(Name = "����� ����������")]
            public string Email { get; set; }

            [Required(ErrorMessage = "������� ������.")]
            [StringLength(500, ErrorMessage = "������� ��� ��� ������ 500 ���.")]
            [Display(Name = "������")]
            public string Message { get; set; }
        }

        [TempData] // ���� �������� ��� ������� HTTP (������ ����� ��� ����� �������)
        public string MessageSent { get; set; } // ���� ����� ����� �������

        public void OnGet()
        {
            // �� ���� ���� ��� ��� ����� ������ ���� ���
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) // ������ �� ��� �������� �������
            {
                return Page(); // ��� ���� �������� ��� ����ɡ ��� ��� ��� ������ �� ����� ������
            }

            // ��� ����� ����� ����� ������ ���������� �� ��� �������� �� ����� ��������.
            // �� ��� ������ ����� ��� ������ ����� ����.

            // ���� ������ �������� �� ���� ������ (Console) ����� ��������
            Console.WriteLine($"����� ����� ��: {Input.Name}");
            Console.WriteLine($"������ ����������: {Input.Email}");
            Console.WriteLine($"�������: {Input.Message}");

            MessageSent = "�� ������ ������ �����! ������� ��� ������.";
            return RedirectToPage(); // ����� ����� �������� ���� ������ ��� �������
        }
    }
}