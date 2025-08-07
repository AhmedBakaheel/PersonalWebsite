$(document).ready(function () {
    // تأثير الترحيب في الصفحة الرئيسية
    // يظهر النص "مرحباً بك في..." تدريجياً
    $(".welcome-heading").hide().fadeIn(2000); // يختفي ثم يظهر ببطء
    $(".welcome-text").hide().delay(1000).fadeIn(2000); // يختفي ثم يظهر ببطء بعد تأخير

    // تأثير على بطاقات المشاريع عند التحويم (Hover)
    // هذا التأثير سيُضاف فوق تأثير الـ CSS السابق، مما يجعله أكثر ديناميكية
    $('.project-card').hover(
        function () {
            // عند دخول الماوس
            $(this).css('transition', 'transform 0.3s ease, box-shadow 0.3s ease');
            $(this).css('transform', 'translateY(-10px) scale(1.02)'); // يرتفع ويكبر قليلاً
            $(this).css('box-shadow', '0 12px 24px rgba(0, 0, 0, 0.2)'); // ظل أكبر وأوضح
        },
        function () {
            // عند خروج الماوس
            $(this).css('transform', 'translateY(0) scale(1)'); // يعود لوضعه الأصلي
            $(this).css('box-shadow', '0 4px 8px rgba(0, 0, 0, 0.1)'); // يعود لظله الأصلي
        }
    );

    // إضافة حركة للمحتوى عند التمرير (Scroll) - تتطلب مكتبة خارجية، لكن سنقوم بمحاكاة بسيطة
    // يمكننا استخدام Intersection Observer API للمزيد من الاحترافية
    // هذا الكود يستخدم jQuery لتحديد العناصر التي ستظهر
    $(window).scroll(function () {
        $('.fade-in-section').each(function () {
            var bottom_of_object = $(this).offset().top + $(this).outerHeight() / 4;
            var bottom_of_window = $(window).scrollTop() + $(window).height();

            if (bottom_of_window > bottom_of_object) {
                $(this).animate({ 'opacity': '1', 'margin-top': '0px' }, 800);
            }
        });
    });
    // إخفاء العناصر في البداية لتظهر بتأثير الـ fade-in
    $('.fade-in-section').css({ 'opacity': '0', 'margin-top': '20px' });
});