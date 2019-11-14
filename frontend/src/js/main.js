import Header from "./component/header";
import Footer from "./component/footer";
import Home from "./component/home";

export default () =>
{
    Pagebuild();
};

function Pagebuild(){
    header();
    home();
    footer();

};
function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header();
}
function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer();
}
function home(){
    const app = document.querySelector('#app')
    app.innerHTML = Home();
}
