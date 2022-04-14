import RipaFormSummaryDetail from '@/components/molecules/RipaFormSummaryDetail.vue'
import { shallowMount } from '@vue/test-utils'
import { API_STOP } from '../../constants/RipaFormContainerTestConstants'
import Vuetify from 'vuetify'

describe('Ripa Form Summary Detail', () => {
  let vuetify
  let wrapper
  let apiStop

  beforeEach(() => {
    vuetify = new Vuetify()
    apiStop = API_STOP
  })

  afterEach(() => {
    wrapper.destroy()
  })

  const factory = propsData => {
    return shallowMount(RipaFormSummaryDetail, {
      vuetify,
      propsData: {
        ...propsData,
        onDeletePerson: jest.fn(),
        onCopyPerson: jest.fn(),
        onEditAgencyQuestions: jest.fn(),
        onEditStop: jest.fn(),
        onEditPerson: jest.fn(),
      },
    })
  }

  it('should match snapshot', () => {
    wrapper = factory({ apiStop: apiStop })

    expect(wrapper.element).toMatchSnapshot()
  })
})
