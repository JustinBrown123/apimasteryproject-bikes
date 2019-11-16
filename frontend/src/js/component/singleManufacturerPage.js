export default function SingleManufacturerPage(manufacturer)  {
    return `
   
        <article>
            <ul>
            <img src=${manufacturer.image} class ="manufacturerImage">
            <input id="manufacturer__id" type="hidden" value="${manufacturer.id}"> </img>
            </ul>
        </article>

            <div class="bicyclesGrid">
            ${manufacturer.bicycles
            .map(bicycle => {
                return `
                <li>
                    <h3>${bicycle.name}</h3>
                    <h4>${bicycle.style}</h4>
                    <img class="bicycle__image" src=${bicycle.image}></img>
                    <p>${bicycle.description}</p>
                    <input class="bicycle__id" type="hidden" value="${bicycle.id}">
                        <button class="edit-bicycle__submit" id="buttonCrud">Edit</button>
                        <button class="delete-bicycle__submit" id="buttonCrud">Delete</button>
                </li>    
                    `;
            })
        .join("")}
        </div>  

        </ul>
        <div class="form">
            <section class="add-item">
         <h2>Add a Bicycle</h1>
            <input class="manufacturer__id" type="hidden" value="${manufacturer.id}">
            <input class="bicycle__name" type='text' placeholder='Add a Bicycle'>
            <input class="bicycle__description"  type='text' placeholder='Add a Bicycle descriptions'>
            <input class="bicycle__type"  type='text' placeholder='Add a Bicycle Type'>          
            <input class="bicycle__img" type="hidden" value="images/bicycledrawing.jpg">
            <button class="add-biycle__submit" id = "buttonCrud">Submit</button>
            </section>
        </div>
        </article>
        <article>
        <div class="editObject">
        <li>
            <h3>${manufacturer.name}</h3>
        </li>
            <input class="manufacturer__id" type="hidden" value="${manufacturer.id}">
            <button class="edit-manufacturer__submit" id="buttonCrud">Edit</button>
            <button class="delete-manufacturer__submit" id="buttonCrud">Delete</button>
            </div> 
        </article>

        
    `;
}