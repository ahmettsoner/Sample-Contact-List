import { ContactTypes } from "./ContactTypes";

export class Contact {
  code!: string;
  personCode!: string;
  type!: ContactTypes;
  content!: number;
}
