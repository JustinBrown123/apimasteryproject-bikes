import Header from "./component/header";
import Footer from "./component/footer";
import Home from "./component/home";
import apiActions from "./API/apiActions";
import Manufacturers from "./component/manufacturers";
import Bicycles from "./component/bicycles";

export default () =>
{
    Pagebuild();
};

function Pagebuild(){
    header();
    home();
    navHome();
    navManufacturers();
    navBicycles();
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
function navHome(){
    const homeButton=document.querySelector(".nav__home")
    homeButton.addEventListener("click", function(){
        document.querySelector("#app").innerHTML = Home(home)
    })
}
function navManufacturers(){
    const manufacturersButton= document.querySelector(".nav__manufacturers")
    const app = document.querySelector("#app")
    manufacturersButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44312/api/manufacturer", manufacturers =>{
          document.querySelector("#app").innerHTML = Manufacturers(manufacturers)
        })
    })
    app.addEventListener("click", function(){
        if(event.target.classList.contains("manufacturer__image")){
            const manufacturerID = event.target.parentElement.querySelector(".manufacturer__id").value;
            console.log(manufacturerID);
            apiActions.getRequest(`https://localhost:44312/api/manufacturer/${manufacturerID}`,
            manufacturer => {
                console.log(manufacturer.bicycles)

                app.innerHTML= Bicycles(manufacturer.bicycles)
             })
        }
    });
}
function navBicycles(){
    const bicyclesButton= document.querySelector(".nav__bicycles")
    const app = document.querySelector("#app")
    bicyclesButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44312/api/bicycle", bicycles =>{
            document.querySelector("#app").innerHTML = Bicycles(bicycles)
        })
    })
    
}



    
