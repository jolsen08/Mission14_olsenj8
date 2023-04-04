import logo from "./414.png";

//Here is our header function which will display the logo for the site as well as the slogan from
//the props

function Header(props: any) {
  return (
    <header className="row">
      <div className="col-4">
        <img src={logo} alt="logo" style={{ width: "200px" }} />
      </div>
      <div className="col">
        <h3>{props.slogan}</h3>
      </div>
    </header>
  );
}

export default Header;
