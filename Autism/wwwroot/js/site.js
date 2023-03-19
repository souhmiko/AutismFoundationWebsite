const toggle = document.getElementById('toggle');
const body = document.querySelector('body');
const icon = toggle.querySelector('icon');

toggle.addEventListener('click', function() {

    this.classList.toggle('bi-moon');
    if (this.classList.toggle('bi-brightness-high-fill')) {
        body.style.background = '#f2f2f2';
        body.style.color = '#333';
        body.style.transition = '2s';
    } else {
        body.style.background = '#333';
        body.style.color = '#f2f2f2';
        toggle.style.color = '#333';
        body.style.transition = '2s';
    }
});