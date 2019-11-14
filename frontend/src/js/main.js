import Header from "./component/header";

export default () =>
{
    Pagebuild();
};

function Pagebuild(){
    header();

};
function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header();
}