document.addEventListener("DOMContentLoaded", (event) => {
    refreshTags();
    const saveTag = document.querySelector('#save-tag');
    saveTag.addEventListener('click', createTag);
});

function createTag() {
    const tagInput = document.querySelector('#new-tag');
    const newTagText = tagInput.value;
    const newTag = {
        text: newTagText,
        reviewId: reviewId
    };
    fetch('api/tags', {
        method: 'POST',
        body: JSON.stringify(newTag),
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(() => {
        tagInput.value = "";
        refreshTags();
    });
}

function refreshTags() {
    const ul = document.querySelector('#tag-list');
    ul.innerHTML = "";

    fetch(`/api/tags/${reviewId}`)
        .then(res => res.json())
        .then(data => {
            console.log(data);
            data.forEach(t => addTagToDom(t));
        }); 
}

function addtagToDom(tag) {
    console.log(tag);
    const li = document.createElement('li');
    li.innerHTML = `${tag.text}`;
    const ul = document.querySelector('#tag-list');
    ul.appendChild(li);
}