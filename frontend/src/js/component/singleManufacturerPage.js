export default function SingleManufacturerPage(manufacturer)  {
    return `
    <div class="manufacturerDetails>
        <article>
            <img class ="singleObject" src=${manufacturer.logo}>
                <input class="manufacturer__id" type="hidden" value="${manufacturer.id}">
            </img>
            <ul>
            <div class="bicyclesGrid">
            ${manufacturer.bicycles
            .map(manufacturer => {
                return `
                <li>
                    <h3>${bicycle.name}</h3>
                    <h4>${bicycle.style}</h4>
                    <img class="bicycles__image" src=${bicycle.image}></img>
                    <p>${bicycle.description}</p>
                    <input class="bicycle__id" type="hidden" value="${bicycle.id}">
                        <button class="edit-bicycle__submit" id="buttonCrud">Edit</button>
                        <button class="delete-bicycle__submit" id="buttonCrud">Delete</button>
                    </li>    
                    `;
            })
        .join("")}    
        </ul>
        <div class="form">
        <section class="add-Bicycle">
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
        
    `
}