import Header from "./component/header";
import Footer from "./component/footer";
import Home from "./component/home";
import apiActions from "./API/apiActions";
import Manufacturers from "./component/manufacturers";
import Bicycles from "./component/bicycles";
import SingleManufacturerPage from "./component/singleManufacturerPage";
import Bicycle from "./component/bicycle";
import Manufacturer from "./component/manufacturer"
import Editbicycle from "./component/editbicycle"



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
        if(event.target.classList.contains("delete-manufacturer__submit")){
            const manufacturerID = event.target.parentElement.querySelector(".manufacturer__id").value;
            console.log("delete" + manufacturerID)
            apiActions.deleteRequest(`https://localhost:44312/api/manufacturers/${manufacturerID}`,
            manufacturers => {
                app.innerHTML = Manufacturers(manufacturers)
            });
        }
    })
    app.addEventListener("click", function(){
        if(event.target.classList.contains("edit-manufacturer__submit")){
            const manufacturerID = event.target.parentElement.querySelector(".manufacturer__id").value;
            console.log("edit" + manufacturerID);
            apiActions.getRequest(`https://localhost:44312/api/manufacturers/${manufacturerID}`,
                manufacturer => {
                app.innerHTML= Manufacturer(manufacturer);
            })
        }
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("update-manufacturer__submit")){
            const manufacturerID = event.target.parentElement.querySelector(
                ".update-manufacturer__id"
            ).value;
            const manufacturerName = event.target.parentElement.querySelector(".update-manufacturer__name"
            ).value;
            const manufacturerDescription = event.target.parentElement.querySelector(".update-manufacturer__description"
            ).value;
            const manufacturerData = {
                id: manufacturerID,
                name: manufacturerName,
                description: manufacturerDescription
            }
            apiActions.putRequest(`https://localhost:44312/api/manufacturers/${manufacturerID}`,
            manufacturerData,
            manufacturers =>{
                app.innerHTML = Manufacturers(manufacturers)
            }
            )
        }

    })

    app.addEventListener('click', function(){
        if(event.target.classList.contains("manufacturer__image")){
            const manufacturerID = event.target.parentElement.querySelector(".manufacturer__id")
            .value;
            apiActions.getRequest(`https://localhost:44312/api/manufacturers/${manufacturerID}`,
            manufacturer => {
                console.log(manufacturer.image)
                
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

 
    app.addEventListener("click", function(){
        if(event.target.classList.contains("add-bicycle__submit")){
            const bicycle = event.target.parentElement.querySelector(
                ".bicycle__name"
            ).value;
            const manufacturerID= event.target.parentElement.querySelector(
                ".manufacturer__id"
            ).value
            const description= event.target.parentElement.querySelector(
                ".bicycle__description"
            ).value;
            const image= event.target.parentElement.querySelector(
                ".bicycle__img"
            ).value;
            const style= event.target.parentElement.querySelector(
                ".bicycle__style"
            ).value;
            console.log(bicycle);
            apiActions.postRequest("https://localhost:44312/api/bicycles",
            {
                name: bicycle,
                description: description,
                style: style,
                manufacturerID: manufacturerID,
                image: image
            },
            bicycles => {
                console.log(bicycles);
                app.innerHTML = Bicycles(bicycles)
            })

        }
    });

    app.addEventListener('click', function(){
        if(event.target.classList.contains("delete-bicycle__submit")){
            const bicycleID = event.target.parentElement.querySelector(".bicycle__id").value;
            console.log("delete" + bicycleID)
            apiActions.deleteRequest(`https://localhost:44312/api/bicycles/${bicycleID}`,
            bicycles => {
                app.innerHTML = Bicycles(bicycles)
            });
        }
    })
    app.addEventListener('click', function(){
        if(event.target.classList.contains("bicycle__image")){
            const bicycleID = event.target.parentElement.querySelector(".bicycle__id")
            .value;
            apiActions.getRequest(`https://localhost:44312/api/bicycles/${bicycleID}`,
            bicycle => {
                console.log(bicycle.image)
                
               document.querySelector("#app").innerHTML = Bicycle(bicycle);

               
             })
        }
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("edit-bicycle__submit")){
            const bicycleID = event.target.parentElement.querySelector(".bicycle__id").value;
            console.log("edit" + bicycleID);
            apiActions.getRequest(`https://localhost:44312/api/bicycles/${bicycleID}`,
                bicycle => {
                    app.innerHTML= Editbicycle(bicycle);
            })
        }
    });
    app.addEventListener('click', function(){
        if(event.target.classList.contains("update-bicycle__submit")){
            const bicycleID = event.target.parentElement.querySelector(
                ".update-bicycle__id").value;
            const bicycle = event.target.parentElement.querySelector(
                ".update-bicycle__name"
            ).value;
            const manufacturerID= event.target.parentElement.querySelector(
                ".update-bicycle__manufacturerid"
            ).value
            const description= event.target.parentElement.querySelector(
                ".update-bicycle__description"
            ).value;
            const image= event.target.parentElement.querySelector(
                ".update-bicycle__image"
            ).value;
            const style= event.target.parentElement.querySelector(
                ".update-bicycle__style"
            ).value;
            const bicycleData = {
                id: bicycleID,
                name: bicycle,
                description: description,
                style: style,
                manufacturerID: manufacturerID,
                image: image
            }
            apiActions.putRequest(`https://localhost:44312/api/bicycles/${bicycleID}`,
            bicycleData,
            bicycles =>{
                app.innerHTML = Bicycles(bicycles)
            })

        }
    });
}


    
