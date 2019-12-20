export default function SingleManufacturerPage(manufacturer)  {
    return `
   
        <article>
        <div class="singleObject">
            <img src=${manufacturer.image} class ="manufacturer__image">
            <p>${manufacturer.description}</p>
            <input id="manufacturer__id" type="hidden" value="${manufacturer.id}"> </img>
        </div>    
        </article>

            <div class="bicyclesGrid">
            ${manufacturer.bicycles
            .map(bicycle => {
                return `
                <li>
                    <h3>${bicycle.name}</h3>
                    <h4>${bicycle.style}</h4>
                    <img class="bicycle__image" src=${bicycle.image}></img>
                    <input class="bicycle__id" type="hidden" value="${bicycle.id}">
                        <button class="edit-bicycle__submit" id="buttonCrud">Edit</button>
                        <button class="delete-bicycle__submit" id="buttonCrud">Delete</button>
                </li>    
                    `;
            })
        .join("")}
        </div>  

        </ul>
        <div class="adding">
 
         <h2>Add a Bicycle</h1>
            <input class="manufacturer__id" type="hidden" value="${manufacturer.id}">
            <input class="bicycle__name" type='text' placeholder='Add a Bicycle'>
            <input class="bicycle__description"  type='text' placeholder='Add a Bicycle descriptions'>
            <input class="bicycle__style"  type='text' placeholder='Add a Bicycle Style'>          
            <input class="bicycle__img" type="hidden" value="images/bicycledrawing.jpg">
            <button class="add-bicycle__submit" id = "buttonCrud">Submit</button>

        </div>
        </article>


        <div class="delete__edit">
            <h3>Make changes to: ${manufacturer.name}</h3>  
            <input class="manufacturer__id" type="hidden" value="${manufacturer.id}">
            <button class="edit-manufacturer__submit" id="buttonCrud">Edit</button>
            <button class="delete-manufacturer__submit" id="buttonCrud">Delete</button>          
        </div> 
        
    `;
}