﻿const toggleClassName = (element, className, expression) => {
    document.querySelector(element).classList.toggle(className, expression)
}

const toggleMenuButton = (attribute) => {
    const btn = document.querySelector(attribute)

    btn.addEventListener('click', function () {
        const element = document.querySelector(btn.getAttribute('data-target'))
        const contains = element.classList.contains('open-menu')

        element.classList.toggle('open-menu', !contains)
        btn.classList.toggle('btn-outline-dark', !contains)
        btn.classList.toggle('btn-toggle-white', !contains)
    })
}






