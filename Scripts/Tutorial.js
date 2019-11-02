document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});

window.onload = function(){
    document.getElementById("lightSwitch").addEventListener("click", HandelSwitch) 
    sessionStorage.setItem("light", "0")
}


function getCondition(){
    let condition = sessionStorage.getItem("light")
    if (condition == "1"){
        sessionStorage.setItem("light", "0")
        return "0";
    }
    else{
        sessionStorage.setItem("light", "1")
        return "1";
    }
}

function LightTheme(){
    document.documentElement.style.setProperty('--HeaderToneA', 'rgb(228, 249, 250)')
    document.documentElement.style.setProperty('--HeaderTextA', 'rgb(0, 0, 0)')

    document.documentElement.style.setProperty('--NavToneA', 'rgb(213, 220, 226)')
    document.documentElement.style.setProperty('--NavHighlightA', 'rgb(35, 84, 88)')
    document.documentElement.style.setProperty('--NavTextA', 'rgb(0, 0, 0)')
    document.documentElement.style.setProperty('--NavHighlightTextA', 'rgb(213, 220, 226)')

    document.documentElement.style.setProperty('--bodyToneA', 'rgb(226, 226, 226)')
    document.documentElement.style.setProperty('--bodyToneB', 'rgb(195, 206, 204)')
    document.documentElement.style.setProperty('--bodyToneC', 'rgb(255, 255, 255)')
    document.documentElement.style.setProperty('--bodyToneD', 'rgb(195, 233, 225)')
    document.documentElement.style.setProperty('--bodyToneE', 'rgb(148, 148, 148)')
    document.documentElement.style.setProperty('--bodyTextA', 'rgb(0, 0, 0)')
}

function DarkTheme(){
    document.documentElement.style.setProperty('--HeaderToneA', 'rgb(37, 35, 46)')
    document.documentElement.style.setProperty('--HeaderTextA', 'rgb(240, 248, 255)')

    document.documentElement.style.setProperty('--NavToneA', 'rgb(45, 43, 51)')
    document.documentElement.style.setProperty('--NavHighlightA', 'rgb(240, 248, 255)')
    document.documentElement.style.setProperty('--NavTextA', 'rgb(240, 248, 255)')
    document.documentElement.style.setProperty('--NavHighlightTextA', 'rgb(68, 65, 80)')

    document.documentElement.style.setProperty('--bodyToneA', '#1b1b1b')
    document.documentElement.style.setProperty('--bodyToneB', 'rgb(65, 69, 71)')
    document.documentElement.style.setProperty('--bodyToneC', 'rgb(45, 43, 51)')
    document.documentElement.style.setProperty('--bodyToneD', 'rgb(0, 27, 49)')
    document.documentElement.style.setProperty('--bodyToneE', 'rgb(18, 19, 20)')
    document.documentElement.style.setProperty('--bodyTextA', 'rgb(240, 248, 255)')
}

function HandelSwitch(){
    let value = getCondition()
    console.log(value)
    if (value == "1"){
        LightTheme()
    } else {
        DarkTheme()
    }

}