export default function bicycle(bicycle){
    return `
    <article>
    <div class=singleObject">
        <section class="main-content__bicycle">
            <h3>${bicycle.name}</h3>          
            <img class="bicycleImage" src=${bicycle.image}></img>
            <h4>${bicycle.style}</h4>
            <p>${bicycle.description}</p>
           
        </section>
        </div>    
</article>
        <div class="editObject">
        <h3>Make changes to: ${bicycle.name}</h3>  
        <input class="bicycle__id" type="hidden" value="${bicycle.id}">
        <button class="edit-bicycle__submit" id="buttonCrud">Edit</button>
        <button class="delete-bicycle__submit" id="buttonCrud">Delete</button>          
    </div> 
        
 
    `
}
