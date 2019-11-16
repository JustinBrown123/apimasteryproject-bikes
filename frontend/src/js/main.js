import Header from "./component/header";
import Footer from "./component/footer";
import Home from "./component/home";
import apiActions from "./API/apiActions";
import Manufacturers from "./component/manufacturers";
import Bicycles from "./component/bicycles";
import SingleManufacturerPage from "./component/singleManufacturerPage";

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
    SingleManufacturerPage();
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
        apiActions.getRequest("https://localhost:44312/api/manufacturers", manufacturers =>{
          document.querySelector("#app").innerHTML = Manufacturers(manufacturers);
        })
    })
    app.addEventListener('click', function(){
        if(event.target.classList.contains("add-manufacturer__submit")){
            const manufacturer = event.target.parentElement.querySelector(
                ".add-manufacturer__manufacturerName"
            ).value;
            const description= event.target.parentElement.querySelector(
                ".add-manufacturer__manufacturerDescription"
            ).value;
            const image= event.target.parentElement.querySelector(
                ".add-manufacturer__manufacturerimg"
            ).value;
            console.log(manufacturer);
            apiActions.postRequest("https://localhost:44312/api/manufacturers",
            {
                name: manufacturer,
                description: description,
                image: image
            },
            manufacturers => {
                console.log(manufacturers);
                app.innerHTML = Manufacturers(manufacturers)
            })

        }
    });

    app.addEventListener('click', function(){
        if(event.target.classList.contains("manufacturerImage")){
            const manufacturerID = event.target.parentElement.querySelector(".manufacturer__id")
            .value;
            console.log(Image)
            apiActions.getRequest(`https://localhost:44312/api/manufacturers/${manufacturerID}`,
            manufacturer => {
                console.log(manufacturer.name)
                
               document.querySelector("#app").innerHTML = SingleManufacturerPage(manufacturer);

               
             })
        }
    });
}
function navBicycles(){
    const bicyclesButton= document.querySelector(".nav__bicycles")
    const app = document.querySelector("#app")
    bicyclesButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44312/api/bicycles", bicycles =>{
            document.querySelector("#app").innerHTML = Bicycles(bicycles)
        })
    })
    
}



    
