const faqs = document.querySelectorAll(".faq");

function toggleActive() {
    this.classList.toggle("active");
}

faqs.forEach(faq => faq.addEventListener("click", toggleActive));