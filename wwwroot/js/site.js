(() => {
    const nav = document.getElementById("cvNav");
    if (!nav) return;

    const links = Array.from(nav.querySelectorAll('a.nav-link[data-section]'));
    const sectionIds = links.map(a => a.getAttribute("data-section"));
    const sections = sectionIds.map(id => document.getElementById(id)).filter(Boolean);

    function setActive(sectionId) {
        links.forEach(a => {
            const isActive = a.getAttribute("data-section") === sectionId;
            a.classList.toggle("active", isActive);
            a.setAttribute("aria-current", isActive ? "page" : "false");
        });
    }

    const observer = new IntersectionObserver(
        (entries) => {
            const visible = entries
                .filter(e => e.isIntersecting)
                .sort((a, b) => b.intersectionRatio - a.intersectionRatio)[0];

            if (visible?.target?.id) setActive(visible.target.id);
        },
        {
            threshold: [0.15, 0.25, 0.35, 0.5, 0.65],
            rootMargin: "-30% 0px -55% 0px"
        }
    );

    sections.forEach(s => observer.observe(s));

    const initial = (location.hash || "#about").replace("#", "");
    if (sectionIds.includes(initial)) setActive(initial);
})();