//This is for the comments
document.addEventListener("DOMContentLoaded", (event) => {
    refreshComments();
    const saveComment = document.querySelector('#save-comment');
    saveComment.addEventListener('click', createComment);
});

function createComment() {
    const commentInput = document.querySelector('#new-comment');
    const newCommentText = commentInput.value;
    const newComment = {
        text: newCommentText,
        reviewId: reviewId
    };
    fetch('/api/comments', {
        method: 'POST',
        body: JSON.stringify(newComment), // data can be `string` or {object}!
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(() => {
        commentInput.value = "";
        refreshComments();
    });
}

function refreshComments() {
    const ol = document.querySelector('#comment-list');
    ol.innerHTML = "";

    fetch(`/api/comments/${reviewId}`)
        .then(res => res.json())
        .then(data => {
            console.log(data);
            data.forEach(c => addCommentToDom(c));
        });
}

function addCommentToDom(comment) {
    console.log(comment);
    const li = document.createElement('li');
    const date = new Date(comment.createdAt);
    li.innerHTML = `${comment.text} ${date.toDateString()}`;
    const ol = document.querySelector('#comment-list');
    ol.appendChild(li);
}

//This is for the tags
//document.addEventListener("DOMContentLoaded", (event) => {
//    refreshTags();
//    const saveTag = document.querySelector('#save-tag');
//    saveTag.addEventListener('click', createTag);
//});

//function createTag() {
//    const tagInput = document.querySelector('#new-tag');
//    const newTagText = tagInput.value;
//    const newTag = {
//        text: newTagText,
//        reviewId: reviewId
//    };
//    fetch('api/tags', {
//        method: 'POST',
//        body: JSON.stringify(newTag),
//        headers: {
//            'Content-Type': 'application/json'
//        }
//    }).then(() => {
//        tagInput.value = "";
//        refreshTags();
//    });
//}

//function refreshTags() {
//    const ul = document.querySelector('#tag-list');
//    ul.innerHTML = "";

//    fetch(`/api/tags/${reviewId}`)
//        .then(res => res.json())
//        .then(data => {
//            console.log(data);
//            data.forEach(t => addTagToDom(t));
//        }); 
//}

//function addtagToDom(tag) {
//    console.log(tag);
//    const li = document.createElement('li');
//    li.innerHTML = `${tag.text}`;
//    const ul = document.querySelector('#tag-list');
//    ul.appendChild(li);
//}