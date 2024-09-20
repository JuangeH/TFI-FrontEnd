const list = document.getElementById("userlist-list");
const amount = 100;

// Render Users
const template = listItem => {
	return `
			<a class="userlist-list-item" href="#">
			  <div class="userlist-list-item__avatar">
			    <img src="${listItem.picture.large}" />
			  </div>
			  <div class="userlist-list-item__content">
					  <strong class="userlist-list-item__name">${listItem.name.first} ${listItem.name.last
		}</strong>
					  <span class="userlist-list-item__info">@${listItem.login.username} <br>  @${listItem.email
		}</span>
					</div>
			  <button type="button" class="userlist-list-item__button">
			  <svg class="feather feather-plus" xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="4" stroke-linecap="round" stroke-linejoin="round" aria-hidden="true" ><line x1="12" y1="5" x2="12" y2="19"></line><line x1="5" y1="12" x2="19" y2="12"></line></svg>
			  </button>
			</a>
  `;
};

fetch(`https://randomuser.me/api/?results=${amount}`, { method: "get" })
	.then(response => response.json())
	.then(data =>
		data.results.forEach(result => (list.innerHTML += template(result)))
	)
	.catch(error => console.log(error));

// Search
const userSearch = document.querySelector("[data-search]");

userSearch.addEventListener("keyup", filter);

function filter() {
	var term = document.querySelector("[data-search]").value.toLowerCase();
	var tag = document.querySelectorAll("[data-searchable] .userlist-list-item");
	for (i = 0; i < tag.length; i++) {
		if (tag[i].innerHTML.indexOf(term) !== -1) {
			tag[i].style.display = "flex";
		} else {
			tag[i].style.display = "none";
		}
	}
}

const recentSearch = document.querySelector(".userlist-recent-search");
const recentSearchList = document.querySelector(".userlist-recent-search__list");
const recentSearchTitle = document.querySelector(".userlist-recent-search__title");
const recentSearchCount = recentSearchList.childNodes.length;
const clearBtn = document.querySelector(".userlist-clear-btn");
const clearSearch = document.querySelector('.userlist-search__clear');

clearSearch.addEventListener('click', () => {
	userSearch.value = "";
	filter();
})

userSearch.addEventListener("keydown", event => {
	const keyName = event.key;
	if (event.key == "Enter") {
		let inputText = userSearch.value.toLowerCase();
		recentSearchList.insertAdjacentHTML(
			"beforeend",
			`<span class="userlist-search-item" onclick="labelSearch('${inputText}')">${inputText}<span class="userlist-search-item__close">×</span></span>`
		);
		if (recentSearchList.childNodes.length > 0) {
			clearBtn.innerHTML = "Clear Items";
			clearBtn.removeAttribute("disabled");
			var btn = document.querySelectorAll(".userlist-search-item__close");

			for (var i = 0; i < btn.length; i++) {
				btn[i].addEventListener("click", function (e) {
					e.currentTarget.parentNode.remove();
				}, false
				);
			}
		}
	} else {
	}
});

function labelSearch(x) {
	userSearch.value = x;
	filter();
}

const clearRecent = () => {
	recentSearchList.innerHTML = "";
	clearBtn.setAttribute("disabled", true);
	clearBtn.innerHTML = "No Recent Items";
	userSearch.value = '';
	filter();
};